using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class WorkingBay
    {
        private  List<Vehicle> VehiclesWorking;

        private static int vehicleNumber = 0;
        private WaitingBay waitingBay = new WaitingBay();
        Mechanic mecanico2 = new Mechanic("Juan", "Leal", 43944249, 600, "Pintor", "Supervisor");
        Mechanic mecanico1 = new Mechanic("Matias", "Ferreira", 46875005, 450, "chapista", "Repairman");
        public void AddVehicle (Vehicle auto){
            if (vehicleNumber<3){
                Order orden = new Order("1/1/21", "Pintura", auto, mecanico1, mecanico2);
                Order.NewOrder(orden);
                VehiclesWorking.Add(auto);
                vehicleNumber++;
                }
            else {
                waitingBay.AddVehicle(auto);
            }
        }

        public void ExitVehicles (Vehicle auto){
            VehiclesWorking.Remove(auto);
            vehicleNumber--;
        }
    }
}