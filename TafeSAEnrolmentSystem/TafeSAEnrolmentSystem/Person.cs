using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Person : Student
    {
        const string DEF_NAME = "No name provided";
        const string DEF_EMAIL = "No email provided";
        const string DEF_PHONE = "No phone number provided";
        private Address address;

        //private string name;
        //private string email;
        //private string phoneNumber;
        public Address PersonAddress { get; set; }
        public string PersonName { get; set; }

        public string PersonEmail { get; set; }

        public string PersonPhoneNumber { get; set; }

        public Person() : this (DEF_NAME, DEF_EMAIL, DEF_PHONE)
        {

        }

        public Person(string name, string email, string phonenumber, Address address) : base()
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phonenumber;
            PersonAddress = address;
            

        }

        public Person(string name, string email, string phonenumber) : this(name, email, phonenumber, new Address())
        {
            PersonName = name;
            PersonEmail = email;
            PersonPhoneNumber = phonenumber;
            PersonAddress = address;
        }

        public override string ToString()
        {
            return base.ToString() +  "Name :" + PersonName + " Email: " + PersonEmail + " Phone Number: " + PersonPhoneNumber + "Persons address: " + PersonAddress;
        }

    }
}
