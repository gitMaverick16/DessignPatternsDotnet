namespace Composite.Example02
{
    public class Employee : IEmployee
    {
        private readonly string _name;
        public Employee(string name)
        {
            _name = name;
        }
        public void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + _name);
        }
    }
}
