using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Enrolment
    {
        const string DEF_ENROL_DATE = "No enrolment date provided";
        const string DEF_GRADE = "No grade provided";
        const string DEF_SEMESTER = "No semester provided";
        private Subject subject;

        public Subject StudentSubject { set; get; }
        public string EnrolmentDate { set; get; }
        public string Grade { set; get; }
        public string Semester { set; get; }

        public Enrolment() : this(DEF_ENROL_DATE, DEF_GRADE, DEF_SEMESTER)
        {

        }
        /// //////////////////////////////////////////////////////////////////////////////////////
        public Enrolment(string enrolmentdate, string grade, string semester, Subject subject)
        {
            EnrolmentDate = enrolmentdate;
            Grade = grade;
            Semester = semester;
            StudentSubject = subject;

        }

        public Enrolment(string enrolmentdate, string grade, string semester) : this(enrolmentdate, grade, semester, new Subject())
        {
            EnrolmentDate = enrolmentdate;
            Grade = grade;
            Semester = semester;
            StudentSubject = subject;
        }

        public override string ToString()
        {
            return "Enrolment Date: " + EnrolmentDate + " Grade: " + Grade + " Semester: " + Semester + " " + StudentSubject;
        }
    }
}
