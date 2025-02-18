using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Student
    {
        const int DEF_STUDENT_ID = -1;
        const string DEF_PROGRAM = "No program provided";
        const string DEF_DATE_REGISTERED = "No register date provided";

        public int StudentID { get; set; }
        public string Program { get; set; }
        public string DateRegistered { get; set; }

        public Student() : this(DEF_STUDENT_ID,DEF_PROGRAM,DEF_DATE_REGISTERED)
        {

        }

        public Student(int studentid, string program, string dateregistered)
        {
            StudentID = studentid;
            Program = program;
            DateRegistered = dateregistered;
        }

        public override string ToString()
        {
            return "Student ID: " + StudentID + " Program: " +Program+ " Date Registered: " + DateRegistered;
        }
    }
}
