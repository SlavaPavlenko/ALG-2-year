using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Item
    {
        public string name { get; set; }
        public double weight { get; set; }
        public double price { get; set; }
        public Item(string _name, double _weight, double _price)
        {
            name = _name;
            weight = _weight;
            price = _price;
        }
    }
}
