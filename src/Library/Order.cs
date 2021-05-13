using System;

namespace Library
{
    public class Order
    {
        private int id;
        public int Id;
        private string date;
        public string Date;
        private string type;
        public string Type;
        private Vehicle assignedVehicle;
        public Vehicle AssignedVehicle;
        private ReplacementPartList partsUsed;
        public ReplacementPartList PartsUsed;
        private int supervisorWorkHours; 
        public int SupervisorWorkHours; 
        private int repairmanWorkHours; 
        public int RepairmanWorkHours; 
        private string status;
        public string Status;
        private Mechanic supervisor;
        public Mechanic Supervisor;
        private Mechanic repairman;
        public Mechanic Repairman;

    }
}
