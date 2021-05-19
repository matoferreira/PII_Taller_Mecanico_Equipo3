using NUnit.Framework;
using System;
using Library;


namespace Tests
{
    public class MechanicTests
    {
       private Mechanic mecanico;
        [SetUp]
        public void Setup()
        {
            this.mecanico = new Mechanic("Matias", "Ferreira", 46875005, 450, "chapista", "Repairman");
        }

        [Test]
        public void TestNameNoNulo()
        {
            Assert.IsNotNull(mecanico.Name);
        }
        [Test]
        public void TestLastNameNoNulo()
        {
            Assert.IsNotNull(mecanico.LastName);
        }
        [Test]
        public void TestCINoNulo()
        {
            Assert.IsNotNull(mecanico.CI);
        }
        [Test]
        public void TestHourlyRateNoNulo()
        {
            Assert.IsNotNull(mecanico.HourlyRate);
        }
        [Test]
        public void HourlyRateMayora0()
        {
            Assert.Greater(mecanico.HourlyRate, 0, "La hora no puede ser negativa ni valer 0", "");
        }
        
        [Test]
        public void TestSpecialityNoNulo()
        {
            Assert.IsNotNull(mecanico.Speciality);
        }
        
        [Test]
        public void TestRoleNoNulo()
        {
            Assert.IsNotNull(mecanico.Role);
        }
    }
}