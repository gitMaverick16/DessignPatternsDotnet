using Builder.cs.Example01;
using Builder.Example02;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Robot builder
            IRobotBuilder builder = new RobotBuilder();
            builder.BuildHead("Round");
            builder.BuildBody("Metal");
            builder.BuildArms("Claws");
            builder.BuildLegs("Wheels");

            var robot = builder.GetRobot();
            robot.DisplayInfo();

            //Burger builder
            IBurgerBuilder burgerBuilder = new ClassicBurgerBuilder();
            burgerBuilder.AddBread();
            burgerBuilder.AddCheese();
            burgerBuilder.AddDressing();
            burgerBuilder.AddLettuce();
            burgerBuilder.AddMeat();
            burgerBuilder.AddTomato();

            var burger = burgerBuilder.GetBurger();
            burger.DisplayInfo();
        }
    }
}
