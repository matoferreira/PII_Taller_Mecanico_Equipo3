using NUnit.Framework;
using System;
using Library;


namespace Tests
{
    public class ReplacementPartTest
    {
       private ReplacementPart Parabrisa;
        [SetUp]
        public void Setup()
        {
            this.Parabrisa = new ReplacementPart("WSHIELD23", "Ford Pyrex", 5000);
        }

        [Test]
        public void TestPartNumberNoNulo()
        {
            Assert.IsNotNull(Parabrisa.PartNumber);
        }
        
        [Test]
        public void TestPartBrandNoNulo()
        {
            Assert.IsNotNull(Parabrisa.PartBrand);
        }

        [Test]
        public void TestPartPriceNoNulo()
        {
            Assert.IsNotNull(Parabrisa.PartPrice);
        }

        [Test]
        public void PriceMayora0()
        {
            Assert.Greater(Parabrisa.PartPrice, 0, "El precio del repuesto no puede ser negativo ni valer 0", "");
        }
    }
}
