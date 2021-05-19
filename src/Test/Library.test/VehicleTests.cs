using NUnit.Framework;
using System;
using Library;


namespace Tests
{
    public class VehicleTests
    {
       private Vehicle Ecosport;
        [SetUp]
        public void Setup()
        {
            this.Ecosport = new Vehicle(124689, "Ford", "Ecosport", 2008, "SCO2340");
        }

        [Test]
        public void TestVINNoNulo()
        {
            Assert.IsNotNull(Ecosport.VIN);

        }

        [Test]
        public void VINMayora0()
        {
            Assert.Greater(Ecosport.VIN, 0, "El VIN no puede ser negativo ni valer 0", "");
        }

        [Test]
        public void TestBrandNoNula()
        {
            Assert.IsNotNull(Ecosport.Brand);

        }
        
        [Test]
        public void TestModelNoNulo()
        {
            Assert.IsNotNull(Ecosport.Model);

        }

        [Test]
        public void TestYearNoNulo()
        {
            Assert.IsNotNull(Ecosport.Year);

        }

        [Test]
        public void YearMayoraAñoPrimerVehiculo()
        {
            Assert.Greater(Ecosport.Year, 1885, "El año no puede ser negativo ni valer menos que 1885", "");
        }

        [Test]
        public void TestLicensePlateNoNulo()
        {
            Assert.IsNotNull(Ecosport.LicensePlate);

        }
    }
}    