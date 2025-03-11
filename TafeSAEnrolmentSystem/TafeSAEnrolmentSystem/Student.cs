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
        /// <summary>
        /// Override the Equals method to test not just for reference equality but also if object is null and then object type. If object type is same 
        /// then checks the StudentID of Student objects for equality
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student s1 = (Student)obj;
            return s1.StudentID == this.StudentID;
        }
        /// <summary>
        /// Override the boolean == operator to compare two student objects for equality when Equals method is called and return true if equal
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator ==(Student s1, Student s2)
        {
            return object.Equals(s1, s2);
        }
        /// <summary>
        /// Override the boolean != operator to compare two student objects for equality when Equals method is called and return true if not equal
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator !=(Student s1, Student s2)
        {
            return !object.Equals(s1, s2);
        }
        /// <summary>
        /// Overriding GetHashCode method to return the StudentID as a hashcode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode();
        }

        /// <summary>
        /// Static equals method to test for object equality and for object null
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns></returns>
        public static bool Equals(object obj1, object obj2)
        {
            if (obj1 == obj2)
                return true;
            if (obj1 == null || obj2 == null)
                return false;
            else
                return obj1.Equals(obj2);
        }
    }
}
