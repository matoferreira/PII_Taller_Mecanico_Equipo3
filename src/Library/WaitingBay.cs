using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class WaitingBay
    {
        private List<Vehicle> VehiclesWaiting;

        private void AddVehicle (Vehicle auto){
            VehiclesWaiting.Add(auto);
        }

        private void ExitVehicles (Vehicle auto){
            VehiclesWaiting.Remove(auto);
        }
    }
}