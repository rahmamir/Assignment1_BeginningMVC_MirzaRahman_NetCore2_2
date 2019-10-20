using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment1_BeginningMVC_MirzaRahman_NetCore2_2.Models
{
    public class Request
    {
        public List<String> FormErrors { get; set; }
        public string Name { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public String Role { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public String RequestDetails { get; set; }
        public int Duration { get; set; }
        public int RequestID { get; set; }

        public Request()
        {

        }

        public Request(string name, string email, String phoneNumber, string role, EquipmentType equipmentType, string requestDetails, int duration, int id)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            EquipmentType = equipmentType;
            RequestDetails = requestDetails;
            Duration = duration;
            RequestID = id;
        }

        public bool validateProperties()
        {
            FormErrors = new List<String>();
            return (checkIfAllPropertiesEntered() && checkIfValidEmail() && 
                checkIfValidPhoneNumber() && checkIfValidDuration());
        }

        public bool checkIfAllPropertiesEntered()
        {
            if(this.GetType().GetProperties().All(p => p.GetValue(this) != null))
            {
                return true;
            }
            FormErrors.Add("Please enter all required Fields!\n");
            return false;
        }

        public bool checkIfValidEmail()
        {
            if(Regex.IsMatch(Email, @".+@.+.com"))
            {
                return true;
            }
            FormErrors.Add("Email must be in Valid Format! {...}@{...}.com\n");
            return false;
        }

        public bool checkIfValidPhoneNumber()
        {
            if( Regex.IsMatch(PhoneNumber, @"[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]"))
            {
                return true;
            }
            FormErrors.Add("Phone Number must be in vald Format! XXX-XXX-XXXX\n");
            return false;
        }

        public bool checkIfValidDuration()
        {
            if (Duration > 0)
            {
                return true;
            }
            FormErrors.Add("Duration must be a positive integer bigger than 0!\n");
            return false;
        }
    }
}
