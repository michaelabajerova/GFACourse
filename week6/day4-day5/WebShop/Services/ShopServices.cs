using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Models.ViewModels;

namespace WebShop.Models
{
    public class ShopServices
    {
        public List<ShopItem> ShopItems { get; set; }

        public ShopServices()
        {
            ShopItems = new List<ShopItem>()
            {
                new ShopItem("Magic Cards","Cards", "A package with which you always predict the card that the viewer chooses. It's the cards who do the job, not you", 250, 10),
                new ShopItem("Fake thumb","Tools", "Most used and also most boring trick", 90, 0),
                new ShopItem("Change Bag","MicroMagic", "Let any item disappear. Doesn't work for humans", 190, 14),
                new ShopItem("Venom","Levitation", "You can flyyyyyyy", 1200, 23),
                new ShopItem("Spider Pen Pro","Street Magic", "You can make things flyyyyyyy", 3100, 3)
            };
        }
        public List<ShopItem> OnlyAvailable()
        {
            return ShopItems.Where(item => item.Quantity> 0).ToList();
        }
        public List<ShopItem> CheapestFirst()
        {
            return ShopItems.OrderBy(item => item.Price).ToList();
        }
        public List<ShopItem> ContainsMagic()
        {
            return ShopItems.Where(item => item.Name.Contains("Cards")).ToList();
        }
        public double AverageStock()
        {
            return ShopItems.Select(item => item.Quantity).Average();
        }
        public List<ShopItem> Search(string search)
        {
            return ShopItems.Where(n => n.Description.ToLower().Contains(search.ToLower()) || n.Name.ToLower().Contains(search.ToLower()) || n.Type.ToLower().Contains(search.ToLower())).ToList();
        }
    }    
}
