using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryProject
{
    public class Item
    {
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalValue { get { return Price * Quantity; } }

        public Item(string _name, decimal _price, int _quantity)
        {
            int priceXTen = (int)(_price * 100);
            Console.WriteLine(priceXTen);
            id = Inventory.idIterator++;
            Name = _name;
            Price = _price;
            Quantity = _quantity;
        }
    }
}
