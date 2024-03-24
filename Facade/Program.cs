using Facade.Example01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Program
    {
        static void Main(string[] args)
        {
            SystemsFacade systemsFacade = new();
            systemsFacade.Operation();
        }
    }
}
