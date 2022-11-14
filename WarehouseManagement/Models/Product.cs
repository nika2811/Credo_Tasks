using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagement.Models
{
    internal class Product
    { 
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public double Quantity { get; set; }

        public Product(string name, string category, decimal price, double quantity)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
        }

        public void Update(decimal price,double quantity)
        {
            Price=price;
            Quantity=quantity;
        }

        public override string ToString()
        {
            return $"Name: {Name} \nCategory: {Category}\nPrice: {Price}\nQuantity: {Quantity}\n";
        }
    }
}
