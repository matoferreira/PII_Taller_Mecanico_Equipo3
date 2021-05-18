using System;

namespace Library
{
    public class ReplacementPart
    {
        private int partNumber;
        private String partBrand;
        private int partPrice;
        public int PartNumber;
        public String PartBrand;
        public int PartPrice;
        public ReplacementPart(int partNumber, String partBrand, int partPrice)
        {
            this.PartNumber = partNumber;
            this.PartBrand = partBrand;
            this.PartPrice = partPrice;
        }
    }
}