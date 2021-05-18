using System;

namespace Library
{
    public class ReplacementPart
    {
        private String partNumber;
        private String partBrand;
        private int partPrice;
        public String PartNumber;
        public String PartBrand;
        public int PartPrice;
        public ReplacementPart(string partNumber, String partBrand, int partPrice)
        {
            this.PartNumber = partNumber;
            this.PartBrand = partBrand;
            this.PartPrice = partPrice;
        }
        public int GetCost()
        {
            return PartPrice;
        }
        public String GetBrand()
        {
            return PartBrand;
        }
        public string GetNumber()
        {
            return PartNumber;
        }
    }
}