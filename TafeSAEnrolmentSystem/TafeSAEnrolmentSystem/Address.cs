using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TafeSAEnrolmentSystem
{
    class Address
    {
        const string DEF_STREET_NUM = "No street number provided";
        const string DEF_STREET_NAME = "No street name provided";
        const string DEF_SUBURB = "No suburb provided";
        const string DEF_POSTCODE = "No postcode provided";
        const string DEF_STATE = "No state provided";

        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        public Address() : this (DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {

        }

        public Address(string streetnum, string streetname, string suburb, string postcode, string state)
        {
            StreetNumber = streetnum;
            StreetName = streetname;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        public override string ToString()
        {
            return "Street Number: " + StreetNumber + " Street Name: " + StreetName + " Suburb: " + Suburb + " Postcode: " + Postcode + " State: " + State;
        }

    }
}
