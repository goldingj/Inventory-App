using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Software1Project
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        
        public void addProduct(Product product)
        {
            Products.Add(product);
        }
         
        public bool removeProduct(Product product)
        {
            return Products.Remove(product);
        }
        
        public Product lookupProduct(int ProductId)
        {
            foreach (var product in Products)
            {
                if (product.ProductId == ProductId)
                {
                    return product;
                }
            }
            return null;
        }
         
        public void updateProduct(int index, Product product)
        {
            Products[index] = product;
        }
        
        public void addPart(Part part)
        {
            AllParts.Add(part);
        }
        
        public bool deletePart(Part part)
        {
            return AllParts.Remove(part);

        }
        
        public Part lookupPart(int PartId)
        {
            foreach(var part in AllParts)
            {
                if (part.PartId == PartId)
                {
                    return part;
                }
            }
            return null;
        }
        
        public void updatePart(int index, Part part)
        {
            AllParts[index] = part;
        }
    }
}
