using System;

namespace Library
{
    public class Order
    {
        private int id;
        public int Id {get;}
        private static int lastid = 0;
        private string date;
        public string Date {get;}
        private string type;
        public string Type {get;}
        private Vehicle assignedVehicle;
        public Vehicle AssignedVehicle {get;}
        private ReplacementPartList partsUsed;
        public ReplacementPartList PartsUsed {get;}        
        private int supervisorWorkHours; 
        public int SupervisorWorkHours {get; set;} 
        private int repairmanWorkHours; 
        public int RepairmanWorkHours {get; set;} 
        private string status;
        public string Status {get; set;}
        private Mechanic supervisor;
        public Mechanic Supervisor {get; set;}
        private Mechanic repairman;
        public Mechanic Repairman {get; set;}

        public Order(string date, string type, Vehicle assignedVehicle)
        {
            this.id = Order.NewID();
            this.date = date;
            this.type = type;
            this.assignedVehicle = assignedVehicle;
            this.partsUsed = new ReplacementPartList();
            this.supervisorWorkHours = 0;
            this.repairmanWorkHours = 0;
        }
        private static int NewID()
        {
            lastid = lastid + 1;
            return lastid;
        }
        public void ChangeStatus()
        {

        }
        public void AddSupervisorWorkHours(int hours)
        {
            this.supervisorWorkHours = this.supervisorWorkHours + hours;
        }
        public void AddRepairmanWorkHours(int hours)
        {
            this.repairmanWorkHours = this.repairmanWorkHours + hours;
        }
        public void AddPartUsed(ReplacementPart part)
        {
            this.partsUsed.AddPart(part);
        }
        public int TotalCost()
        {
            int costototal = 0;
            foreach (ReplacementPart part in this.partsUsed)
            {
                costototal = costototal + part.partPrice;
            }
            return costototal;
        }

    }
}
