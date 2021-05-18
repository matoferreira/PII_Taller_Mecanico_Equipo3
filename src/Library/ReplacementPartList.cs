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
        public int GetListCost()
        {
            foreach (ReplacementPart Part in this.ReplacementList)
            {
                totalCost = totalCost + Part.GetCost();
            }
            return totalCost;
        }
        // Faltaría un GetListBrand y GetListNumber si es necesario
    }
}