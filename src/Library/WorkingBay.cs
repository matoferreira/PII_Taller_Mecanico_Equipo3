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

    
        public void AddVehicle (Vehicle auto){
            if (vehicleNumber<3){
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