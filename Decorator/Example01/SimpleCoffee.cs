namespace Decorator.Example01
{
    public class SimpleCoffee : ICoffee
    {
        public double GetCost()
        {
            return 1;
        }

        public string GetDescription()
        {
            return "Simple coffee";
        }
    }
}
