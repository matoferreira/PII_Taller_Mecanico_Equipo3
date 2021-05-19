using System;

namespace Library
{
    public class Order
    {
        public int Id {get;}
        private static int lastid = 0;
        public string Date {get;}
        public string Type {get;}
        public Vehicle AssignedVehicle {get;}
        public ReplacementPartList PartsUsed {get;}        
        public int SupervisorWorkHours {get; set;} 
        public int RepairmanWorkHours {get; set;} 
        public string Status {get; set;}
        public Mechanic Supervisor {get; set;}
        public Mechanic Repairman {get; set;}

        public Order(string date, string type, Vehicle assignedVehicle)
        {
            Id = Order.NewID();
            Date = date;
            Type = type;
            AssignedVehicle = assignedVehicle;
            PartsUsed = new ReplacementPartList(this.Id.ToString());
            SupervisorWorkHours = 0;
            RepairmanWorkHours = 0;
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
            SupervisorWorkHours = this.SupervisorWorkHours + hours;
        }
        public void AddRepairmanWorkHours(int hours)
        {
            RepairmanWorkHours = RepairmanWorkHours + hours;
        }
        public void AddPartUsed(ReplacementPart part)
        {
            PartsUsed.AddPart(part);
        }
        public int TotalCost()
        {
            return PartsUsed.GetListCost();
        }

    }
}
