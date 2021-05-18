using System;
using System.Collections;

namespace Library
{
    public class ReplacementPartList
    {
        private String name;
        private ArrayList replacementList;
        public String Name;
        public ArrayList ReplacementList;
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
        /* Agregar el método de sacar el costo de la parte en ReplacementPart
        public int GetListCost()
        {
            foreach (ReplacementPart Part in this.ReplacementList)
            {
                totalCost = 
            }
        } */
    }
}