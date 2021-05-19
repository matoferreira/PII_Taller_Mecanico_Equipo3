using System;
using System.Collections;
/* Se crea una clase ReplacementPartList que es la responsable de tener una lista de partes.
Se opta por crear esta clase para cumplir con el principio de SRP y no darle esta responsabilidad a la clase Order.
La razón de esto es que, de esta manera, ReplacementPartList es la responsable de la lista de partes y su modificación.
A su vez, por Expert, es la que tiene los conocimientos para calcular el total del costo.
*/
namespace Library
{
    public class ReplacementPartList
    {
        public String Name {get;}
        public ArrayList ReplacementList {get;}
        private ArrayList replacementList 
        {
            set
            {
                replacementList = value;
            }
        }
        public ReplacementPartList(string name)
        {
            this.Name = name;
            this.replacementList = new ArrayList();
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