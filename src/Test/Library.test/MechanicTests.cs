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
    }
}