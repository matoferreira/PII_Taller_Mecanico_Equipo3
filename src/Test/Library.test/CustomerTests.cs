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
        public void TestCINula() // Cambiá el nombre para indicar qué estás probando
        {
            Assert.IsNull(cliente.ID);
        }
        [Test]
        public void TestCIValida() // Cambiá el nombre para indicar qué estás probando
        {
            cliente.ID = "4.394.424-9";
            Assert.True(IdUtils.IdIsValid(cliente.ID));
        }

        [Test]
        public void TestCIInvalida() // Si el guion es incorrecto asigna null al ID
        {
            cliente.ID = "3.333.333-0";
            Assert.IsNull(cliente.ID, "Cuidado: CI incorrecta");
        }

        [Test]
        public void TestnombreNoNulo() // nombre no nulo
        {
            cliente.Name = "Juan";
            Assert.IsNotNull(cliente.Name);
        }
        [Test]
        public void TestnombreNoVacio() // nombre no vacio
        {
            cliente.Name = "Juan";
            Assert.IsNotEmpty(cliente.Name);
        }
    }
}