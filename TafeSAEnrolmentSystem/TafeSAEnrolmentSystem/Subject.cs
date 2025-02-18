using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Subject
    {
        const string DEF_SUBJECT_CODE = "No subject code provided";
        const string DEF_SUBJECT_NAME = "No subject name provided";
        const double DEF_SUBJECT_COST = -1;

        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double SubjectCost { get; set; }

        public Enrolment StudentEnrolment { get; set; }

        public Subject() : this(DEF_SUBJECT_CODE, DEF_SUBJECT_NAME, DEF_SUBJECT_COST)
        {

        }

        public Subject(string subjectcode, string subjectname, double subjectcost)
        {
            SubjectCode = subjectcode;
            SubjectName = subjectname;
            SubjectCost = subjectcost;
        }


        public override string ToString()
        {
            return "Subject Code: " + SubjectCode + " Subject Name: " + SubjectName + " Subject Cost: " + SubjectCost;
        }





    }
}
