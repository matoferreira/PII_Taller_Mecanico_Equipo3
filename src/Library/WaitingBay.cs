using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class WaitingBay
    {
        private List<Vehicle> VehiclesWaiting;

        public void AddVehicle (Vehicle auto){
            VehiclesWaiting.Add(auto);
        }

        public void ExitVehicles (Vehicle auto){
            VehiclesWaiting.Remove(auto);
        }
    }
}