/*Acorde a los Patrones y principios vistos en clase:
Se crea una clase ReplacementPartList que es la responsable de tener una lista de partes.
Se opta por crear esta clase para cumplir con el principio de SRP y no darle esta responsabilidad a la clase Order.
La razón de esto es que ReplacementPartList es la responsable de la lista de partes y su modificación, teniendo una sola razón de cambio.
A su vez, por Expert, es la que tiene los conocimientos para calcular el total del costo de la lista, al pedirle la información a cada parte
para despues calcular el total.*/
using System;
using System.Collections;

namespace Library
{
    public class ReplacementPartList
    {
        public String Name {get;}
        public ArrayList ReplacementList {get; set;}
        public ReplacementPartList(string name, ArrayList replacementList)
        {
            this.Name = name;
            this.ReplacementList = replacementList;
        }
        public void AddPart(ReplacementPart Part)
        {
            ReplacementList.Add(Part);
        }
        public void RemovePart(ReplacementPart Part)
        {
            ReplacementList.Remove(Part);
        }
        public int totalCost = 0;
        public int GetListCost()
        {
            foreach (ReplacementPart Part in this.ReplacementList)
            {
                totalCost = totalCost + Part.GetCost();
            }
            return totalCost;
        }
    }
}