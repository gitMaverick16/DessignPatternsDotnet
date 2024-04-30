namespace Decorator.Example02
{
    public class CheeseDecorator : BurgerDecorator
    {
        public CheeseDecorator(IBurger burger) : base(burger)
        {
        }

        public override string GetDescription()
        {
            return _burger.GetDescription() +", cheese";
        }

        public override double GetCost()
        {
            return _burger.GetCost() + 1.5;
        }
    }
}
