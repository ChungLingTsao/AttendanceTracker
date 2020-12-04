/* 
 * AttendanceApp.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: An attendance application for Whitecliffe tutors that helps track student attendance.
 *              This application is mainly used by the students to sign themselves in and out.
*/

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceApp
{
    public partial class Form1 : Form
    {
        Student currentStudent = new Student();
        string connectionString = "server=localhost;Port=3306;user=root;Password=root;database=attendance;";

        public List<string> studentTypes = new List<string>();

        MySqlConnection connection;
        MySqlCommand command;

        MySqlDataReader Reader;
        public int selectedID;

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            command = connection.CreateCommand();

            // Populating the studentTypes comboBox
            studentTypes.AddRange(new string[] { "Full-Time Student", "Part-Time Student", "Custom Student" });
            foreach (String city in studentTypes)
            {
                studenttypeComboBox.Items.Add(city);
            }
        }

        // Searches the student database for names containing the entered string
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                string query = "select * from student WHERE studentName like '%" + nameTextBox.Text + "%'";
                command.CommandText = query;
                connection.Open();
                searchListBox1.Items.Clear();
                Reader = command.ExecuteReader();
                string thisrow;

                while (Reader.Read())
                {
                    thisrow = "";
                    string currentName = Reader.GetValue(Reader.GetOrdinal("studentName")).ToString();

                    string currentID = Reader.GetValue(Reader.GetOrdinal("studentID")).ToString();

                    // Converting DB value for signIn to a boolean
                    var currentSignIn = Reader.GetOrdinal("signIn");
                    bool currentSignIn2 = Reader.GetBoolean(currentSignIn);

                    // Setting strings depending on what boolean signIn is recieved
                    string stringStatus;
                    if (currentSignIn2 == true)
                    {
                        stringStatus = "SIGNED IN";
                    }
                    else if (currentSignIn2 == false)
                    {
                        stringStatus = "SIGNED OUT";
                    }
                    else { stringStatus = "ERROR"; }

                    thisrow += "#" + currentID.ToString() + " - " + currentName + " - " + stringStatus;
                    searchListBox1.Items.Add(thisrow);
                }
            }
            else {
                searchListBox1.Items.Clear(); // In case user starts typing and then clears textbox
            }
            connection.Close();
        }

        // When a student is selected, the user will be navigated to the student panel
        private void searchListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentPanel.Visible = true;
            string studentString;
            
            // Attempts to handle rare crashes when a selectedItem cannot be stringified
            try
            {
                studentString = searchListBox1.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            // Taking the studentID portion of the selected string from the ListBox
            String[] seperator = {"#", " "};
            string[] studentVar = studentString.Split(seperator, 2, StringSplitOptions.RemoveEmptyEntries);
            selectedID = Int32.Parse(studentVar[0]);
            currentStudent.StudentID = selectedID;

            // Using the studentID to find the rest of the student information
            string query = "select * from student WHERE StudentID = " + currentStudent.StudentID.ToString();
            command.CommandText = query;
            connection.Open();
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                string currentName = Reader.GetValue(Reader.GetOrdinal("studentName")).ToString();
                string currentID = Reader.GetValue(Reader.GetOrdinal("studentID")).ToString();
                string currentSignIn = Reader.GetValue(Reader.GetOrdinal("signIn")).ToString();

                currentStudent.Name = currentName;
                currentStudent.StudentID = Int32.Parse(currentID);
                currentStudent.SignIn = bool.Parse(currentSignIn);

                studentiddisplaytTextBox.Text = currentStudent.StudentID.ToString();
                nameheadingLabel.Text = currentStudent.Name;
                statusheadingTextBox.Text = currentStudent.SignIn.ToString();
            }

            // Changes tab to the student tab
            tablessControl.SelectedIndex = 1;

            // Changes elements for student panel depending on SignIn status
            if (currentStudent.SignIn == true) {
                signinoutButton.Text = "SIGN OUT";
                statusheadingTextBox.Text = "SIGNED IN";
                statusheadingTextBox.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                signinoutButton.Text = "SIGN IN";
                statusheadingTextBox.Text = "SIGNED OUT";
                statusheadingTextBox.ForeColor = System.Drawing.Color.Red;
            }
            connection.Close();
        }

        // Handles the signin/signout of a student.
        private void signinoutButton_Click(object sender, EventArgs e)
        {
            string updatequery = "";
            string insertquery = "";

            // Retrieving the current date time in two different string formats
            string dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string dt2 = DateTime.Now.ToString("HH:mm:ss");

            // Used to create a message box that automatically closes in 5 seconds
            var w = new Form() { Size = new Size(0, 0) };
            Task.Delay(TimeSpan.FromSeconds(5)).ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            //Student sign in
            if (currentStudent.SignIn == false)
            {
                currentStudent.SignIn = true;

                updatequery = "UPDATE student SET signIn = true WHERE studentID = " + currentStudent.StudentID.ToString();
                insertquery = "INSERT INTO log (studentID, startTime) VALUES('" + currentStudent.StudentID +"', '"+ dt +"')";

                statusheadingTextBox.Text = "SIGNED IN";
                statusheadingTextBox.ForeColor = System.Drawing.Color.Green;

                MessageBox.Show(w, "You have signed in at: " + dt2 + "\n\nPress OK or wait 5 seconds to return to student selection", "SUCCESS");

                GoToClearStudentSelectScreen();
                signinoutButton.Text = "Sign Out";
            }
            //Student sign out
            else if (currentStudent.SignIn == true)
            {
                currentStudent.SignIn = false;
                updatequery = "UPDATE student SET signIn = false WHERE studentID = " + currentStudent.StudentID.ToString();

                // Updates the endTime of the student session for the latest logID created
                insertquery = "UPDATE log SET endTime = '" + dt + "' WHERE studentID = " + currentStudent.StudentID.ToString() + " ORDER BY `logID` DESC LIMIT 1";

                statusheadingTextBox.Text = "SIGNED OUT";
                statusheadingTextBox.ForeColor = System.Drawing.Color.Red;

                MessageBox.Show(w, "You have signed out at: " + dt2 + "\n\nPress OK or wait 5 seconds to return to student selection", "SUCCESS");

                GoToClearStudentSelectScreen();
                signinoutButton.Text = "Sign In";
            }
            // If error occurs
            else
            {
                MessageBox.Show(w, "Error: Student SignIn status unknown. Set to SIGNED OUT", "SUCCESS");
                currentStudent.SignIn = false;
                signinoutButton.Text = "Sign In";
            }
            command.CommandText = updatequery;
            connection.Open();
            command.ExecuteNonQuery();
            command.CommandText = insertquery;
            command.ExecuteNonQuery();
            connection.Close();
        }

        // Handler for clear button
        private void clearButton_Click(object sender, EventArgs e)
        {
            GoToClearStudentSelectScreen();
        }

        // Handler for the student back button
        private void backButton1_Click(object sender, EventArgs e)
        {
            GoToClearStudentSelectScreen();
        }

        // Used to get the current time
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeTextBox.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        // Used to set the current time to the time label
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeTextBox.Text = DateTime.Now.ToLongTimeString();
        }

        // Function to clear the textbox for inputting student name
        private void GoToClearStudentSelectScreen()
        {
            tablessControl.SelectedIndex = 0;
            nameTextBox.Text = "";
            nameTextBox.Focus();
        }

        // Handler for the course link label
        private void courseLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://computerpowerplus.ac.nz/it-training-domestic-students.html");
            
        }

        // Combobox that is used to display attendance hours in a listbox based on student type selected
        // Note: The reason the information is not displayed in a textbox is due to the assessment requirements
        //       of requiring THREE listboxes.
        private void studenttypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            studenttypeListBox.Items.Clear();
            var selectedItem = studenttypeComboBox.Text;

            switch (selectedItem)
            {
                case "Full-Time Student":
                    studenttypeListBox.Items.Add("20 hours on campus");
                    studenttypeListBox.Items.Add("Per Week");
                    break;
                case "Part-Time Student":
                    studenttypeListBox.Items.Add("10 hours on campus");
                    studenttypeListBox.Items.Add("Per Week");
                    break;
                case "Custom Student":
                    studenttypeListBox.Items.Add("Custom hours on campus");
                    studenttypeListBox.Items.Add("Per Week");
                    break;
                default:
                    studenttypeListBox.Items.Add("ERROR");
                    break;
            }
        }

        // Handler to open mail application to start composing an email
        private void emailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:cpp@hotmail.com");
        }

        // Handler for admin button to navigate to the admin tab
        private void adminButton_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedIndex = 2;
        }

        // Used to output the log for the selected days of the current week. 
        // NOTE: The current week feature is not fully working as their is some functionally issue with the start of the week
        //       If used on Sunday, the 'Monday' that is used is next Monday and not the previous Monday.
        //       This is due to how Sunday is the start of the week (0) used for DateTime
        private void comboattendanceButton_Click(object sender, EventArgs e)
        {
            searchListBox2.Items.Clear();
            List<int> checkedDayList = new List<int>();

            foreach (var item in dayCheckedListBox.CheckedItems)
            {
                string day = item.ToString();
                int indexDay = dayCheckedListBox.Items.IndexOf(day) + 1; // 1 is added as DateTime starts on Sunday

                checkedDayList.Add(indexDay);
            }

            //first day of week
            DateTime monday2 = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            var monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday).ToString("yyyy-MM-dd");

            //weekstartingdateLabel.Text = monday.ToString();
            weekstartingdateLabel.Text = "2020-07-21";

            var dayList = new List<string>();

            foreach (String day in dayCheckedListBox.CheckedItems)
            {
                dayList.Add(day);
                var currentDay = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);
            }

            List<int> selectedDaysOfWeek = new List<int>();

            // Next show the object title and check state for each item selected.
            foreach (object itemChecked in dayCheckedListBox.CheckedItems)
            {
                selectedDaysOfWeek.Add(dayCheckedListBox.Items.IndexOf(itemChecked));
            }

            string query;
            foreach (int indexDay in selectedDaysOfWeek) {
                // Currently set monday as "2020-07-21". Datetime start of the week is on Sundays.
                query = "SELECT * FROM log LEFT JOIN student ON log.studentID = student.studentID WHERE startTime >= '" + "2020-07-21" + " 00:00:00' AND endTime < '" + monday2.AddDays(indexDay).ToString("yyyy-MM-dd") + " 00:00:00'";
                command.CommandText = query;
                connection.Open();
                Reader = command.ExecuteReader();
                string thisrow;

                switch (indexDay) 
                {
                    case 0:
                        searchListBox2.Items.Add("Monday: ");
                        break;
                    case 1:
                        searchListBox2.Items.Add("Tuesday:");
                        break;
                    case 2:
                        searchListBox2.Items.Add("Wednesday:");
                        break;
                    case 3:
                        searchListBox2.Items.Add("Thursday:");
                        break;
                    case 4:
                        searchListBox2.Items.Add("Friday:");
                        break;
                    case 5:
                        searchListBox2.Items.Add("Saturday:");
                        break;
                    case 6:
                        searchListBox2.Items.Add("Sunday:");
                        break;

                }
                while (Reader.Read())
                {
                    thisrow = "";

                    string currentID = Reader.GetValue(Reader.GetOrdinal("studentID")).ToString();
                    string currentName = Reader.GetValue(Reader.GetOrdinal("studentName")).ToString();
                    DateTime currentStart = (DateTime)Reader.GetValue(Reader.GetOrdinal("startTime"));
                    string currentStartString = currentStart.ToString("hh:mm:ss");
                    DateTime currentEnd = (DateTime)Reader.GetValue(Reader.GetOrdinal("endTime"));
                    string currentEndString = currentEnd.ToString("hh:mm:ss");
                    thisrow += " " + currentID + " - " + currentName + " (" + currentStartString + " - " +currentEndString +")";
                    searchListBox2.Items.Add(thisrow);
                }
                searchListBox2.Items.Add("");
                connection.Close();
            }

            connection.Close();
        }

        // AddFile button handler that is used to import a text file with studentnames and IDs to insert students into database
        private void addfileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                string[] filelines = File.ReadAllLines(filename);

                List<Student> studentList = new List<Student>();
                int linesPerStudent = 2; //amount of text lines used for a student in the TXT file
                int currentStudentLine = 0;

                Student student = new Student();

                for (int a = 0; a < filelines.Length; a++)
                {
                    //check when to move to next student
                    if (a != 0 && a % linesPerStudent == 0)
                    {
                        studentList.Add(student);
                        student = new Student();
                        currentStudentLine = 1;
                    }
                    else
                    {
                        currentStudentLine++;
                    }

                    switch (currentStudentLine)
                    {
                        case 1:
                            student.StudentID = Convert.ToInt32(filelines[a].Trim());
                            break;
                        case 2:
                            student.Name = filelines[a].Trim();
                            break;
                    }

                    // For adding the last student from the text file for the final FOR loop iteration
                    if (a == filelines.Length - 1) { studentList.Add(student); }

                }

                // Used to insert students into database
                foreach (Student emp in studentList)
                {
                    string query = "INSERT INTO student (studentID, studentName) VALUES('" + emp.StudentID.ToString() + "', '" + emp.Name + "')";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        
                        // Trys to insert new students to database
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Success! Student/s added");
                        }
                        
                        catch (Exception ex)
                        {
                            // If student info already exists
                            if (ex.Message.ToLower().Contains("duplicate entry"))
                            {
                                MessageBox.Show("Error: A student already exists (Duplicate Entry)");
                            }
                            else
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        connection.Close();
                    }
                }
            }
        }

        // Used to show all currently signed and is outputted to a listbox 
        private void showallButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT studentName, signIn FROM log LEFT JOIN student ON log.studentID = student.studentID WHERE endTime IS NULL";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);//        connection.CreateCommand();                                                    //command.CommandText = query;

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    searchListBox2.Items.Clear();
                    Reader = command.ExecuteReader();

                    string thisrow;

                    while (Reader.Read())
                    {
                        thisrow = "";
                        string currentName = Reader.GetValue(Reader.GetOrdinal("studentName")).ToString();

                        thisrow += currentName;
                        searchListBox2.Items.Add(thisrow);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
            }
        }

        // Handler for the back button in Admin tab
        private void backButton2_Click(object sender, EventArgs e)
        {
            GoToClearStudentSelectScreen();
        }

        // Enables/Displays the get attendance button depending on if an item has been checked in the checklistbox
        private void dayCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dayCheckedListBox.CheckedItems.Count > 0)
            {
                comboattendanceButton.Enabled = true;
            }
            else {
                comboattendanceButton.Enabled = false;
            }
        }

        // Opens a dialog to save the current text in searchListBox2 to a TXT file.
        private void savefileButton_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(sfd.FileName, searchListBox2.Items.Cast<string>().ToArray()); // Casting as ListBox uses collections
                }
            }
        }
    }
}
