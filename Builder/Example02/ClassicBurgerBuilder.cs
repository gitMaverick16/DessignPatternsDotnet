namespace Builder.Example02
{
    public class ClassicBurgerBuilder : IBurgerBuilder
    {
        private readonly Burger _burger;
        public ClassicBurgerBuilder()
        {
            _burger = new Burger();
        }
        public void AddBread()
        {
            _burger.Bread = "classic bread";
        }

        public void AddCheese()
        {
            _burger.Cheese = "classic cheese";
        }

        public void AddDressing()
        {
            _burger.Dressing = "classic dressing";
        }

        public void AddLettuce()
        {
            _burger.Lettuce = "classic lettuce";
        }

        public void AddMeat()
        {
            _burger.Meat = "classic meat";
        }

        public void AddTomato()
        {
            _burger.Tomato = "classic tomato";
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
