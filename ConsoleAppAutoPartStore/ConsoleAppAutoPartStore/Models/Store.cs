using System;
using System.Collections.Generic;

namespace AutoPartsStore.Models
{
    public class Store
    {
        private List<Part> parts = new List<Part>();

        public void AddPart(Part part)
        {
            parts.Add(part);
            Console.WriteLine($" Part {part.Name} added to store.");
        }

        public void DisplayAllParts()
        {
            Console.WriteLine("\n--- Store Inventory ---");
            foreach (var part in parts)
            {
                part.DisplayInfo();
            }
        }

        public Part FindPartByCode(string code)
        {
            foreach (var part in parts)
            {
                if (part.Code == code) return part;
            }
            return null;
        }
    }
}
