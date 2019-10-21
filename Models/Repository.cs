using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_BeginningMVC_MirzaRahman_NetCore2_2.Models
{
    public static class Repository//general storage class for the lists of both requests and equipment
    {
        private static List<Request> _listOfRequests;//contains all requests
        private static List<Equipment> _listOfEquipment;//contains all equipment
        private static int GeneratedRequestID;
        private static int GeneratedEquipmentID;

        static Repository()//initializes equipments and requests to some default values
        {
            GeneratedRequestID = 4;
            GeneratedEquipmentID = 5;
            _listOfRequests = new List<Request>
            {
                new Request {RequestID = 3, Duration = 20, Email = "sd@sd.com", EquipmentType = EquipmentType.Phone, Name = "Testing", PhoneNumber = "226-600-3320", RequestDetails = "Details ZERG SWARM", Role = "Student" }
            };
            _listOfEquipment = new List<Equipment>
            {
                new Equipment {EquipmentID = 0, EquipmentType = EquipmentType.Laptop, Availability = true, Description = "Lenovo "},
                new Equipment {EquipmentID = 1, EquipmentType = EquipmentType.Phone, Availability = true, Description = "Android Phone Ringke"},
                new Equipment {EquipmentID = 2, EquipmentType = EquipmentType.Tablet, Availability = false, Description = "Samsung Tablet"}
            };
        }

        public static List<Request> Requests => _listOfRequests;
        public static List<Equipment> EquipmentList => _listOfEquipment;
        public static void AddToRepository(Request request)//adds a new request to storage if valid (check done in controller)
        {
            request.RequestID = GeneratedRequestID;
            _listOfRequests.Add(request);
            GeneratedRequestID++;
        }
        public static void AddToEquipmentList(Equipment equipment)//adds a new equipment to storage, may be used later
        {
            equipment.EquipmentID = GeneratedEquipmentID;
            _listOfEquipment.Add(equipment);
            GeneratedEquipmentID++;
        }

    } 
}
