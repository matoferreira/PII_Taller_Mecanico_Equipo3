using System;
using Library;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
             
            WorkingBay workingBay = new WorkingBay();
            Vehicle auto = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Vehicle auto2 = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Vehicle auto3 = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Vehicle auto4 = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Vehicle auto5 = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            workingBay.AddVehicle(auto);
            workingBay.AddVehicle(auto2);
            workingBay.AddVehicle(auto3);
            workingBay.AddVehicle(auto4);
            workingBay.AddVehicle(auto5);
        }
    }
}
