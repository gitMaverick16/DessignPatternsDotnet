using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Example01
{
    public class CancelOrderCommand : ICommand
    {
        private Order _order;
        public CancelOrderCommand(Order order)
        {
            _order = order;
        }
        public void Execute()
        {
            _order.Cancel();
        }
    }
}
