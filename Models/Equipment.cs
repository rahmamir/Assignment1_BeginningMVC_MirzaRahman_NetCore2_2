using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1_BeginningMVC_MirzaRahman_NetCore2_2.Models
{
    public class Equipment
    { 
        public int EquipmentID { get; set; }
        public EquipmentType EquipmentType { get; set; }
        public String Description { get; set; }
        public bool Availability { get; set; }

        public Equipment()
        {

        }

        public Equipment(int equipmentID, EquipmentType equipmentType, string description, bool availability)
        {
            EquipmentID = equipmentID;
            EquipmentType = equipmentType;
            Description = description;
            Availability = availability;
        }
    }
}
