using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1Project
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void addAssociatedPart(Part associatedPart)
        {
            AssociatedParts.Add(associatedPart);
        }
        
        public bool removeAssociatedPart(Part associatedPart) 
        {
            return AssociatedParts.Remove(associatedPart);
        }
        
        public Part lookupAssociatedParts(int partId)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
