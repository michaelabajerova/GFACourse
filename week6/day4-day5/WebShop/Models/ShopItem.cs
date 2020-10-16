using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models.ViewModels
{
    public class ShopItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }

        public ShopItem(string name, string description, double price, int quantity, string type)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Type = type;
        }
    }
}
