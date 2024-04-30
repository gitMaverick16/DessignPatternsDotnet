using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Example01
{
    public class WhippedCreamDecorator : CoffeeDecorator
    {
        public WhippedCreamDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", whipped cream";
        }

        public override double GetCost()
        {
            return _coffee.GetCost() + 0.7;
        }
    }
}
