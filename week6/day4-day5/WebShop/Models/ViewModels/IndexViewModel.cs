using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<ShopItem> ShopItems { get; set; }
        public double Average { get; set; }

        public IndexViewModel(List<ShopItem> shopItems)
        {
            ShopItems = shopItems;
        }
    }
}
