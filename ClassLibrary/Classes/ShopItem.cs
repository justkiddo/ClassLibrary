using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Interfaces;

namespace ClassLibrary.Classes
{
    public class ShopItem: IItem
    {
        public ShopItem(string name, decimal? price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price ?? throw new ArgumentNullException(nameof(price));
        }

        public string Name { get; init; }
        public decimal Price { get; set; }
    }
}
