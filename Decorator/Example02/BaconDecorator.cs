namespace Decorator.Example02
{
    public class BaconDecorator : BurgerDecorator
    {
        public BaconDecorator(IBurger burger) : base(burger)
        {
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() + ", bacon";
        }

        public override double GetCost()
        {
            return _burger.GetCost() + 3.2;
        }
    }
}
