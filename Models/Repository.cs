using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_BeginningMVC_MirzaRahman_NetCore2_2.Models
{
    public static class Repository
    {
        private static List<Request> _listOfRequests;
        private static List<Equipment> _listOfEquipment;
        private static int GeneratedRequestID;
        private static int GeneratedEquipmentID;

        static Repository()
        {
            GeneratedRequestID = 3;
            GeneratedEquipmentID = 0;
            _listOfRequests = new List<Request>();
            _listOfEquipment = new List<Equipment>
            {
                new Equipment {EquipmentID = 0, Availability = true, Description = "Laptop"},
                new Equipment {EquipmentID = 1, Availability = true, Description = "Phone"},
                new Equipment {EquipmentID = 2, Availability = true, Description = "Tablet"}
            };
        }

        public static List<Request> Requests => _listOfRequests;
        public static List<Equipment> EquipmentList => _listOfEquipment;
        public static void AddToRepository(Request request)
        {
            request.RequestID = GeneratedRequestID;
            _listOfRequests.Add(request);
            GeneratedRequestID++;
        }
        public static void AddToEquipmentList(Equipment equipment)
        {
            equipment.EquipmentID = GeneratedEquipmentID;
            GeneratedEquipmentID++;
            _listOfEquipment.Add(equipment);
        }

    } 
}
