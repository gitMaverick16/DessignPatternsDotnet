namespace Decorator.Example02
{
    public class BasicBurger : IBurger
    {
        public double GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Basic burger";
        }
    }
}
