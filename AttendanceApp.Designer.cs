namespace AttendanceApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablessControl = new AttendanceApp.TablessControl();
            this.mainTabPage = new System.Windows.Forms.TabPage();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.emailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.newstudentTextBox = new System.Windows.Forms.TextBox();
            this.adminButton = new System.Windows.Forms.Button();
            this.requiredhoursGroupBox = new System.Windows.Forms.GroupBox();
            this.studenttypeListBox = new System.Windows.Forms.ListBox();
            this.courseLinkLabel = new System.Windows.Forms.LinkLabel();
            this.moreinfoTextBox = new System.Windows.Forms.TextBox();
            this.studenttypeComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.headinglabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchListBox1 = new System.Windows.Forms.ListBox();
            this.typenameLabel = new System.Windows.Forms.Label();
            this.studenTabPage = new System.Windows.Forms.TabPage();
            this.studentPanel = new System.Windows.Forms.Panel();
            this.studentidLabel = new System.Windows.Forms.Label();
            this.backButton1 = new System.Windows.Forms.Button();
            this.nameheadingLabel = new System.Windows.Forms.Label();
            this.signinoutButton = new System.Windows.Forms.Button();
            this.adminTabPage = new System.Windows.Forms.TabPage();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.savefileButton = new System.Windows.Forms.Button();
            this.addstudentGroupBox = new System.Windows.Forms.GroupBox();
            this.formatfileinfoTextBox = new System.Windows.Forms.TextBox();
            this.addfileinfoTextBox = new System.Windows.Forms.TextBox();
            this.addfileButton = new System.Windows.Forms.Button();
            this.attendancedayGroupBox = new System.Windows.Forms.GroupBox();
            this.weekstartingLabel = new System.Windows.Forms.Label();
            this.comboattendanceButton = new System.Windows.Forms.Button();
            this.weekstartingdateLabel = new System.Windows.Forms.Label();
            this.dayCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.headingLabel2 = new System.Windows.Forms.Label();
            this.backButton2 = new System.Windows.Forms.Button();
            this.showallButton = new System.Windows.Forms.Button();
            this.searchListBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.studentiddisplaytTextBox = new System.Windows.Forms.TextBox();
            this.statusheadingTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.tablessControl.SuspendLayout();
            this.mainTabPage.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.requiredhoursGroupBox.SuspendLayout();
            this.studenTabPage.SuspendLayout();
            this.studentPanel.SuspendLayout();
            this.adminTabPage.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.addstudentGroupBox.SuspendLayout();
            this.attendancedayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablessControl
            // 
            this.tablessControl.Controls.Add(this.mainTabPage);
            this.tablessControl.Controls.Add(this.studenTabPage);
            this.tablessControl.Controls.Add(this.adminTabPage);
            this.tablessControl.Location = new System.Drawing.Point(2, 2);
            this.tablessControl.Name = "tablessControl";
            this.tablessControl.SelectedIndex = 0;
            this.tablessControl.Size = new System.Drawing.Size(1351, 730);
            this.tablessControl.TabIndex = 7;
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.mainPanel);
            this.mainTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabPage.Size = new System.Drawing.Size(1343, 704);
            this.mainTabPage.TabIndex = 0;
            this.mainTabPage.Text = "tabPage3";
            this.mainTabPage.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.timeTextBox);
            this.mainPanel.Controls.Add(this.emailLinkLabel);
            this.mainPanel.Controls.Add(this.newstudentTextBox);
            this.mainPanel.Controls.Add(this.adminButton);
            this.mainPanel.Controls.Add(this.requiredhoursGroupBox);
            this.mainPanel.Controls.Add(this.clearButton);
            this.mainPanel.Controls.Add(this.headinglabel1);
            this.mainPanel.Controls.Add(this.nameTextBox);
            this.mainPanel.Controls.Add(this.searchListBox1);
            this.mainPanel.Controls.Add(this.typenameLabel);
            this.mainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainPanel.Location = new System.Drawing.Point(-4, 3);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1347, 701);
            this.mainPanel.TabIndex = 7;
            // 
            // emailLinkLabel
            // 
            this.emailLinkLabel.AutoSize = true;
            this.emailLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLinkLabel.Location = new System.Drawing.Point(1139, 486);
            this.emailLinkLabel.Name = "emailLinkLabel";
            this.emailLinkLabel.Size = new System.Drawing.Size(180, 25);
            this.emailLinkLabel.TabIndex = 12;
            this.emailLinkLabel.TabStop = true;
            this.emailLinkLabel.Text = "Click here to start";
            this.emailLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLinkLabel_LinkClicked);
            // 
            // newstudentTextBox
            // 
            this.newstudentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newstudentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newstudentTextBox.Location = new System.Drawing.Point(923, 461);
            this.newstudentTextBox.Multiline = true;
            this.newstudentTextBox.Name = "newstudentTextBox";
            this.newstudentTextBox.Size = new System.Drawing.Size(396, 63);
            this.newstudentTextBox.TabIndex = 14;
            this.newstudentTextBox.Text = "For new students, please email your Name and Student ID :";
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(923, 530);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(381, 129);
            this.adminButton.TabIndex = 13;
            this.adminButton.Text = "Go to Admin Control";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // requiredhoursGroupBox
            // 
            this.requiredhoursGroupBox.Controls.Add(this.studenttypeListBox);
            this.requiredhoursGroupBox.Controls.Add(this.courseLinkLabel);
            this.requiredhoursGroupBox.Controls.Add(this.moreinfoTextBox);
            this.requiredhoursGroupBox.Controls.Add(this.studenttypeComboBox);
            this.requiredhoursGroupBox.Location = new System.Drawing.Point(907, 111);
            this.requiredhoursGroupBox.Name = "requiredhoursGroupBox";
            this.requiredhoursGroupBox.Size = new System.Drawing.Size(419, 335);
            this.requiredhoursGroupBox.TabIndex = 9;
            this.requiredhoursGroupBox.TabStop = false;
            this.requiredhoursGroupBox.Text = "Required Hours on Campus";
            // 
            // studenttypeListBox
            // 
            this.studenttypeListBox.FormattingEnabled = true;
            this.studenttypeListBox.ItemHeight = 33;
            this.studenttypeListBox.Location = new System.Drawing.Point(16, 82);
            this.studenttypeListBox.Name = "studenttypeListBox";
            this.studenttypeListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.studenttypeListBox.Size = new System.Drawing.Size(381, 169);
            this.studenttypeListBox.TabIndex = 12;
            // 
            // courseLinkLabel
            // 
            this.courseLinkLabel.AutoSize = true;
            this.courseLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLinkLabel.Location = new System.Drawing.Point(198, 293);
            this.courseLinkLabel.Name = "courseLinkLabel";
            this.courseLinkLabel.Size = new System.Drawing.Size(189, 25);
            this.courseLinkLabel.TabIndex = 10;
            this.courseLinkLabel.TabStop = true;
            this.courseLinkLabel.Text = "course information";
            this.courseLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.courseLinkLabel_LinkClicked);
            // 
            // moreinfoTextBox
            // 
            this.moreinfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.moreinfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreinfoTextBox.Location = new System.Drawing.Point(16, 268);
            this.moreinfoTextBox.Multiline = true;
            this.moreinfoTextBox.Name = "moreinfoTextBox";
            this.moreinfoTextBox.Size = new System.Drawing.Size(381, 50);
            this.moreinfoTextBox.TabIndex = 11;
            this.moreinfoTextBox.Text = "For more information regarding study hours, refer to your";
            // 
            // studenttypeComboBox
            // 
            this.studenttypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studenttypeComboBox.Location = new System.Drawing.Point(16, 35);
            this.studenttypeComboBox.Name = "studenttypeComboBox";
            this.studenttypeComboBox.Size = new System.Drawing.Size(381, 41);
            this.studenttypeComboBox.TabIndex = 9;
            this.studenttypeComboBox.SelectedIndexChanged += new System.EventHandler(this.studenttypeComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(770, 147);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 40);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // headinglabel1
            // 
            this.headinglabel1.AutoSize = true;
            this.headinglabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headinglabel1.Location = new System.Drawing.Point(6, 0);
            this.headinglabel1.Name = "headinglabel1";
            this.headinglabel1.Size = new System.Drawing.Size(804, 73);
            this.headinglabel1.TabIndex = 2;
            this.headinglabel1.Text = "Whitecliffe Attendance App";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(19, 147);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(745, 40);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // searchListBox1
            // 
            this.searchListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchListBox1.FormattingEnabled = true;
            this.searchListBox1.ItemHeight = 33;
            this.searchListBox1.Location = new System.Drawing.Point(19, 193);
            this.searchListBox1.Name = "searchListBox1";
            this.searchListBox1.Size = new System.Drawing.Size(869, 466);
            this.searchListBox1.TabIndex = 1;
            this.searchListBox1.SelectedIndexChanged += new System.EventHandler(this.searchListBox1_SelectedIndexChanged);
            // 
            // typenameLabel
            // 
            this.typenameLabel.AutoSize = true;
            this.typenameLabel.Location = new System.Drawing.Point(13, 111);
            this.typenameLabel.Name = "typenameLabel";
            this.typenameLabel.Size = new System.Drawing.Size(355, 33);
            this.typenameLabel.TabIndex = 4;
            this.typenameLabel.Text = "Start by typing your name:";
            // 
            // studenTabPage
            // 
            this.studenTabPage.Controls.Add(this.studentPanel);
            this.studenTabPage.Location = new System.Drawing.Point(4, 22);
            this.studenTabPage.Name = "studenTabPage";
            this.studenTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.studenTabPage.Size = new System.Drawing.Size(1343, 704);
            this.studenTabPage.TabIndex = 1;
            this.studenTabPage.Text = "tabPage4";
            this.studenTabPage.UseVisualStyleBackColor = true;
            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.statusheadingTextBox);
            this.studentPanel.Controls.Add(this.studentiddisplaytTextBox);
            this.studentPanel.Controls.Add(this.studentidLabel);
            this.studentPanel.Controls.Add(this.backButton1);
            this.studentPanel.Controls.Add(this.nameheadingLabel);
            this.studentPanel.Controls.Add(this.signinoutButton);
            this.studentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.studentPanel.Location = new System.Drawing.Point(0, 0);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(1343, 704);
            this.studentPanel.TabIndex = 5;
            this.studentPanel.Visible = false;
            // 
            // studentidLabel
            // 
            this.studentidLabel.AutoSize = true;
            this.studentidLabel.Location = new System.Drawing.Point(34, 101);
            this.studentidLabel.Name = "studentidLabel";
            this.studentidLabel.Size = new System.Drawing.Size(163, 36);
            this.studentidLabel.TabIndex = 7;
            this.studentidLabel.Text = "Student ID:";
            // 
            // backButton1
            // 
            this.backButton1.Location = new System.Drawing.Point(40, 543);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(180, 130);
            this.backButton1.TabIndex = 6;
            this.backButton1.Text = "Back";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // nameheadingLabel
            // 
            this.nameheadingLabel.AutoSize = true;
            this.nameheadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.nameheadingLabel.Location = new System.Drawing.Point(27, 15);
            this.nameheadingLabel.Name = "nameheadingLabel";
            this.nameheadingLabel.Size = new System.Drawing.Size(204, 73);
            this.nameheadingLabel.TabIndex = 2;
            this.nameheadingLabel.Text = "label4";
            // 
            // signinoutButton
            // 
            this.signinoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinoutButton.Location = new System.Drawing.Point(247, 174);
            this.signinoutButton.Name = "signinoutButton";
            this.signinoutButton.Size = new System.Drawing.Size(1064, 499);
            this.signinoutButton.TabIndex = 1;
            this.signinoutButton.Text = "t";
            this.signinoutButton.UseVisualStyleBackColor = true;
            this.signinoutButton.Click += new System.EventHandler(this.signinoutButton_Click);
            // 
            // adminTabPage
            // 
            this.adminTabPage.Controls.Add(this.adminPanel);
            this.adminTabPage.Location = new System.Drawing.Point(4, 22);
            this.adminTabPage.Name = "adminTabPage";
            this.adminTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.adminTabPage.Size = new System.Drawing.Size(1343, 704);
            this.adminTabPage.TabIndex = 2;
            this.adminTabPage.Text = "tabPage1";
            this.adminTabPage.UseVisualStyleBackColor = true;
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.savefileButton);
            this.adminPanel.Controls.Add(this.addstudentGroupBox);
            this.adminPanel.Controls.Add(this.attendancedayGroupBox);
            this.adminPanel.Controls.Add(this.headingLabel2);
            this.adminPanel.Controls.Add(this.backButton2);
            this.adminPanel.Controls.Add(this.showallButton);
            this.adminPanel.Controls.Add(this.searchListBox2);
            this.adminPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanel.Location = new System.Drawing.Point(0, 3);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(1343, 701);
            this.adminPanel.TabIndex = 21;
            // 
            // savefileButton
            // 
            this.savefileButton.Location = new System.Drawing.Point(1000, 20);
            this.savefileButton.Name = "savefileButton";
            this.savefileButton.Size = new System.Drawing.Size(318, 94);
            this.savefileButton.TabIndex = 23;
            this.savefileButton.Text = "Save log to TXT file";
            this.savefileButton.UseVisualStyleBackColor = true;
            this.savefileButton.Click += new System.EventHandler(this.savefileButton_Click);
            // 
            // addstudentGroupBox
            // 
            this.addstudentGroupBox.Controls.Add(this.formatfileinfoTextBox);
            this.addstudentGroupBox.Controls.Add(this.addfileinfoTextBox);
            this.addstudentGroupBox.Controls.Add(this.addfileButton);
            this.addstudentGroupBox.Location = new System.Drawing.Point(428, 487);
            this.addstudentGroupBox.Name = "addstudentGroupBox";
            this.addstudentGroupBox.Size = new System.Drawing.Size(890, 186);
            this.addstudentGroupBox.TabIndex = 22;
            this.addstudentGroupBox.TabStop = false;
            // 
            // formatfileinfoTextBox
            // 
            this.formatfileinfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.formatfileinfoTextBox.Location = new System.Drawing.Point(330, 56);
            this.formatfileinfoTextBox.Multiline = true;
            this.formatfileinfoTextBox.Name = "formatfileinfoTextBox";
            this.formatfileinfoTextBox.Size = new System.Drawing.Size(188, 122);
            this.formatfileinfoTextBox.TabIndex = 17;
            this.formatfileinfoTextBox.Text = "StudentID \r\nStudentName\r\nStudentID2\r\nStudentName2\r\n...";
            // 
            // addfileinfoTextBox
            // 
            this.addfileinfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addfileinfoTextBox.Location = new System.Drawing.Point(15, 30);
            this.addfileinfoTextBox.Multiline = true;
            this.addfileinfoTextBox.Name = "addfileinfoTextBox";
            this.addfileinfoTextBox.Size = new System.Drawing.Size(529, 49);
            this.addfileinfoTextBox.TabIndex = 16;
            this.addfileinfoTextBox.Text = "To add students via text file, make sure the text file is formatted as such for e" +
    "ach line:";
            // 
            // addfileButton
            // 
            this.addfileButton.Location = new System.Drawing.Point(555, 30);
            this.addfileButton.Name = "addfileButton";
            this.addfileButton.Size = new System.Drawing.Size(313, 134);
            this.addfileButton.TabIndex = 15;
            this.addfileButton.Text = "Add new student via TXT file";
            this.addfileButton.UseVisualStyleBackColor = true;
            this.addfileButton.Click += new System.EventHandler(this.addfileButton_Click);
            // 
            // attendancedayGroupBox
            // 
            this.attendancedayGroupBox.Controls.Add(this.weekstartingLabel);
            this.attendancedayGroupBox.Controls.Add(this.comboattendanceButton);
            this.attendancedayGroupBox.Controls.Add(this.weekstartingdateLabel);
            this.attendancedayGroupBox.Controls.Add(this.dayCheckedListBox);
            this.attendancedayGroupBox.Location = new System.Drawing.Point(40, 108);
            this.attendancedayGroupBox.Name = "attendancedayGroupBox";
            this.attendancedayGroupBox.Size = new System.Drawing.Size(367, 407);
            this.attendancedayGroupBox.TabIndex = 21;
            this.attendancedayGroupBox.TabStop = false;
            // 
            // weekstartingLabel
            // 
            this.weekstartingLabel.AutoSize = true;
            this.weekstartingLabel.Location = new System.Drawing.Point(16, 27);
            this.weekstartingLabel.Name = "weekstartingLabel";
            this.weekstartingLabel.Size = new System.Drawing.Size(219, 25);
            this.weekstartingLabel.TabIndex = 14;
            this.weekstartingLabel.Text = "For the week starting:";
            // 
            // comboattendanceButton
            // 
            this.comboattendanceButton.Enabled = false;
            this.comboattendanceButton.Location = new System.Drawing.Point(21, 311);
            this.comboattendanceButton.Name = "comboattendanceButton";
            this.comboattendanceButton.Size = new System.Drawing.Size(317, 73);
            this.comboattendanceButton.TabIndex = 12;
            this.comboattendanceButton.Text = "Get Attendence Log";
            this.comboattendanceButton.UseVisualStyleBackColor = true;
            this.comboattendanceButton.Click += new System.EventHandler(this.comboattendanceButton_Click);
            // 
            // weekstartingdateLabel
            // 
            this.weekstartingdateLabel.AutoSize = true;
            this.weekstartingdateLabel.Location = new System.Drawing.Point(241, 27);
            this.weekstartingdateLabel.Name = "weekstartingdateLabel";
            this.weekstartingdateLabel.Size = new System.Drawing.Size(36, 25);
            this.weekstartingdateLabel.TabIndex = 20;
            this.weekstartingdateLabel.Text = "    ";
            // 
            // dayCheckedListBox
            // 
            this.dayCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCheckedListBox.FormattingEnabled = true;
            this.dayCheckedListBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.dayCheckedListBox.Location = new System.Drawing.Point(21, 74);
            this.dayCheckedListBox.MultiColumn = true;
            this.dayCheckedListBox.Name = "dayCheckedListBox";
            this.dayCheckedListBox.Size = new System.Drawing.Size(317, 214);
            this.dayCheckedListBox.TabIndex = 11;
            this.dayCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.dayCheckedListBox_SelectedIndexChanged);
            // 
            // headingLabel2
            // 
            this.headingLabel2.AutoSize = true;
            this.headingLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel2.Location = new System.Drawing.Point(31, 20);
            this.headingLabel2.Name = "headingLabel2";
            this.headingLabel2.Size = new System.Drawing.Size(382, 73);
            this.headingLabel2.TabIndex = 3;
            this.headingLabel2.Text = "Admin Page";
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(40, 543);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(180, 130);
            this.backButton2.TabIndex = 19;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // showallButton
            // 
            this.showallButton.Location = new System.Drawing.Point(676, 20);
            this.showallButton.Name = "showallButton";
            this.showallButton.Size = new System.Drawing.Size(318, 94);
            this.showallButton.TabIndex = 18;
            this.showallButton.Text = "Show All Signed In Students";
            this.showallButton.UseVisualStyleBackColor = true;
            this.showallButton.Click += new System.EventHandler(this.showallButton_Click);
            // 
            // searchListBox2
            // 
            this.searchListBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchListBox2.FormattingEnabled = true;
            this.searchListBox2.ItemHeight = 25;
            this.searchListBox2.Location = new System.Drawing.Point(428, 120);
            this.searchListBox2.Name = "searchListBox2";
            this.searchListBox2.Size = new System.Drawing.Size(890, 354);
            this.searchListBox2.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.ShowReadOnly = true;
            this.openFileDialog1.Title = "Browse Text Files";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // studentiddisplaytTextBox
            // 
            this.studentiddisplaytTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentiddisplaytTextBox.Location = new System.Drawing.Point(203, 103);
            this.studentiddisplaytTextBox.Name = "studentiddisplaytTextBox";
            this.studentiddisplaytTextBox.Size = new System.Drawing.Size(196, 34);
            this.studentiddisplaytTextBox.TabIndex = 8;
            this.studentiddisplaytTextBox.Text = "textbox";
            // 
            // statusheadingTextBox
            // 
            this.statusheadingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusheadingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusheadingTextBox.Location = new System.Drawing.Point(910, 15);
            this.statusheadingTextBox.Name = "statusheadingTextBox";
            this.statusheadingTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusheadingTextBox.Size = new System.Drawing.Size(401, 55);
            this.statusheadingTextBox.TabIndex = 9;
            this.statusheadingTextBox.Text = "SIGNED OUT";
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(1039, 15);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(287, 55);
            this.timeTextBox.TabIndex = 15;
            this.timeTextBox.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.tablessControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event-Driven Programming: Final Assessment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tablessControl.ResumeLayout(false);
            this.mainTabPage.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.requiredhoursGroupBox.ResumeLayout(false);
            this.requiredhoursGroupBox.PerformLayout();
            this.studenTabPage.ResumeLayout(false);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.adminTabPage.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.addstudentGroupBox.ResumeLayout(false);
            this.addstudentGroupBox.PerformLayout();
            this.attendancedayGroupBox.ResumeLayout(false);
            this.attendancedayGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox searchListBox1;
        private System.Windows.Forms.Label headinglabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label typenameLabel;
        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Button signinoutButton;
        private System.Windows.Forms.Panel mainPanel;
        private TablessControl tablessControl;
        private System.Windows.Forms.TabPage mainTabPage;
        private System.Windows.Forms.TabPage studenTabPage;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label nameheadingLabel;
        private System.Windows.Forms.Button backButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox studenttypeComboBox;
        private System.Windows.Forms.LinkLabel courseLinkLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label studentidLabel;
        private System.Windows.Forms.GroupBox requiredhoursGroupBox;
        private System.Windows.Forms.TabPage adminTabPage;
        private System.Windows.Forms.Label headingLabel2;
        private System.Windows.Forms.LinkLabel emailLinkLabel;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.CheckedListBox dayCheckedListBox;
        private System.Windows.Forms.Button comboattendanceButton;
        private System.Windows.Forms.ListBox searchListBox2;
        private System.Windows.Forms.Label weekstartingLabel;
        private System.Windows.Forms.Button addfileButton;
        private System.Windows.Forms.TextBox formatfileinfoTextBox;
        private System.Windows.Forms.TextBox addfileinfoTextBox;
        private System.Windows.Forms.Button showallButton;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Label weekstartingdateLabel;
        private System.Windows.Forms.TextBox moreinfoTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox newstudentTextBox;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.GroupBox addstudentGroupBox;
        private System.Windows.Forms.GroupBox attendancedayGroupBox;
        private System.Windows.Forms.Button savefileButton;
        private System.Windows.Forms.ListBox studenttypeListBox;
        private System.Windows.Forms.TextBox studentiddisplaytTextBox;
        private System.Windows.Forms.TextBox statusheadingTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
    }
}

