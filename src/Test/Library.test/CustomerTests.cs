using NUnit.Framework;
using System;
using Library;


namespace Tests
{
    public class CustomerTests
    {
        private Customer cliente;
        private IdUtils idUtils;
        [SetUp]
        public void Setup()
        {
            this.cliente = new Customer("Juan","Perez",0999999,"4809233-4");
            this.idUtils = new IdUtils();
        }

        [Test]
        public void TestCINoNula() // 
        {
            cliente.ID = "4.394.424-9";
            Assert.IsNotNull(cliente.ID);
        }

         [Test]
        
        
        public void TestCIValida() // Cambiá el nombre para indicar qué estás probando
        {
            
            Assert.True(IdUtils.IdIsValid(cliente.ID));
        }

        [Test]
        public void TestPhoneNumber() // Si el telefono es correcto
        {
            cliente.NumberPhone = 099999999;
            Assert.AreEqual(cliente.NumberPhone, 099999999);
        }

        [Test]
        public void TestnombreNoNulo() // Cambiá el nombre para indicar qué estás probando
        {
            cliente.Name = "Juan";
            Assert.IsNotNull(cliente.Name);
        }
        [Test]
        public void Testapellido() // Cambiá el nombre para indicar qué estás probando
        {
            cliente.LastName = "Perez";
            Assert.AreEqual(cliente.LastName, "Perez");
        }
    }
}