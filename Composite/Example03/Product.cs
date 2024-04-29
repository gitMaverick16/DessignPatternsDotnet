using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example03
{
    public class Product : IComponent
    {
        private string _name;
        private double _price;
        public Product(string name, double price)
        {
            _name = name;
            _price = price;
        }
        public void ShowPrice()
        {
            Console.WriteLine($"{_name} - Price: ${_price}");
        }
    }
}
