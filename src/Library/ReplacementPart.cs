using System;

namespace Library
{
    public class ReplacementPart
    {
        public String PartNumber {get;}
        public String PartBrand {get;}
        public int PartPrice {get;}
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