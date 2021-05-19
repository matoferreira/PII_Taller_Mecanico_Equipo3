using System;
using System.Collections;

namespace Library
{
    public class WaitingBay
    {
        private ArrayList VehiclesWaiting;

        private void AddVehicle (){
            VehiclesWaiting.Add(Vehicle);
        }

        private void ExitVehicles (){
            VehiclesWaiting.Remove(Vehicle);
        }
    }
}