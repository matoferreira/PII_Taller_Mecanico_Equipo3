using System;

namespace Library
{
    public class Vehicle
    {
        private int vIN;
        private String brand;
        private String model;
        private int year;
        private String licensePlate;
        public int VIN;
        public String Brand;
        public String Model;
        public int Year;
        public String LicensePlate;
        public Vehicle (int vIN, String brand, String model, int year, String licensePlate)
        {
            this.VIN = vIN;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.LicensePlate = licensePlate;
        }
        public int GetVIN()
        {
            return VIN;
        }
        public String GetBrand()
        {
            return Brand;
        }
        public String GetModel()
        {
            return Model;
        }
        public int GetYear()
        {
            return Year;
        }
        public String GetLicensePlate()
        {
            return LicensePlate;
        }
    }
}