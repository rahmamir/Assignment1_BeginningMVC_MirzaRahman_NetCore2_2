using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_BeginningMVC_MirzaRahman_NetCore2_2.Models
{
    public class Request
    {
        public enum type
        {
            Laptop, Phone, Tablet, Another
        }

        public string Name { get; set; }
        public String Email { get; set; }
        public int PhoneNumber { get; set; }
        public String Role { get; set; }
        public type EquipmentType { get; set; }
        public String RequestDetails { get; set; }
        public int Duration { get; set; }
        public int ID { get; set; }

        public Request()
        {

        }

        public Request(string name, string email, int phoneNumber, string role, type equipmentType, string requestDetails, int duration, int id)
        {
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Role = role;
            EquipmentType = equipmentType;
            RequestDetails = requestDetails;
            Duration = duration;
            ID = id;
        }
    }
}
