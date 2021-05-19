/*Acorde a los Patrones y principios vistos en clase:
ReplacementPart cumple con SRP porque tiene una sola razón de cambio,
la cual es por cómo estan compuestos los repuestos.
En cuanto a Expert, la misma es la Experta en saber el precio de cada parte para, en un método de otra clase,
poder obtener el costo total de todos los repuestos.*/
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
    }
}