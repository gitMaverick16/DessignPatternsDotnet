using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Example02
{
    public class Manager : IEmployee
    {
        private readonly string _name;
        private readonly List<IEmployee> _employees;
        public Manager(string name)
        {
            _name = name;
            _employees = new List<IEmployee>();
        }

        public void Add(IEmployee employee)
        {
            _employees.Add(employee);
        }
        public void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + _name);
            foreach(var employee in _employees)
            {
                employee.Display(indent + 2);
            }
        }
    }
}
