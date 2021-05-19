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
            Mechanic mecanico2 = new Mechanic("Juan", "Leal", 43944249, 600, "Pintor", "Supervisor");
            Mechanic mecanico1 = new Mechanic("Matias", "Ferreira", 46875005, 450, "chapista", "Repairman");
            Vehicle auto = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Vehicle auto2 = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Vehicle auto3 = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Vehicle auto4 = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Vehicle auto5 = new Vehicle(123, "Mercedes", "Benz", 1999, "ABC1224");
            Order orden = new Order("1/1/21", "Pintura", auto, mecanico1, mecanico2);
            Order orden2 = new Order("1/1/21", "Pintura", auto, mecanico1, mecanico2);
            Order orden3 = new Order("1/1/21", "Pintura", auto, mecanico1, mecanico2);
            Order orden4 = new Order("1/1/21", "Pintura", auto, mecanico1, mecanico2);
            Order orden5 = new Order("1/1/21", "Pintura", auto, mecanico1, mecanico2);
            Order.NewOrder(orden);
            Order.NewOrder(orden2);
            Order.NewOrder(orden3);
            Order.NewOrder(orden4);
            Order.NewOrder(orden5);
        }
    }
}
