namespace Builder.Example02
{
    public class VeggieBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public VeggieBurgerBuilder()
        {
            _burger = new Burger();
        }
        public void AddBread()
        {
            _burger.Bread = "veggie bread";
        }

        public void AddCheese()
        {
            _burger.Cheese = "veggie cheese";
        }

        public void AddDressing()
        {
            _burger.Dressing = "veggie dressing";
        }

        public void AddLettuce()
        {
            _burger.Lettuce = "veggie lettuce";
        }

        public void AddMeat()
        {
            _burger.Meat = "veggie meat";
        }

        public void AddTomato()
        {
            _burger.Tomato = "veggie tomato";
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
