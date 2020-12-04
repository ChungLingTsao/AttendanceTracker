/*
 * Student.cs
 * Author: Chung-Ling Tsao (92019797)
 * Description: Implements a student for the attendance app
 */

namespace AttendanceApp
{
    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public bool SignIn { get; set; }

        // Default constructor
        public Student() { }

        // Three parameter constructor used to initialise the student's properties
        //public Student(int sID, string sName, bool sSignIn)
        //{
        //    StudentID = sID;
        //    Name = sName;
        //    SignIn = sSignIn;
        //}
    }
}
