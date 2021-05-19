using System;

namespace Library
{
    public class Vehicle
    {
        public int VIN {get;}
        public String Brand {get;}
        public String Model {get;}
        public int Year {get;}
        public String LicensePlate {get;}
        public Vehicle (int vIN, String brand, String model, int year, String licensePlate)
        {
            this.VIN = vIN;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.LicensePlate = licensePlate;
        }
    }
}