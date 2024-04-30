namespace Decorator.Example02
{
    public abstract class BurgerDecorator : IBurger
    {
        public readonly IBurger _burger;
        public BurgerDecorator(IBurger burger)
        {
            _burger = burger;
        }
        public virtual double GetCost()
        {
            return _burger.GetCost();
        }

        public virtual string GetDescription()
        {
            return _burger.GetDescription();
        }
    }
}
