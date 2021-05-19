using System;
using System.Collections;

namespace Library
{
    public class WorkingBay
    {
        public ArrayList VehiclesWorking;

        private static int vehicleNumber = 0;

    
        public void AddVehicle (){
            if (vehicleNumber<2){
                VehiclesWorking.Add(Vehicle);
                vehicleNumber++;
                }
        }

        public void ExitVehicles (){
            VehiclesWorking.Remove(Vehicle);
            vehicleNumber--;
        }
    }
}