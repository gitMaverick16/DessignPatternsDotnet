using Builder.cs.Example01;
using Builder.Example02;
using Builder.Example03;

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

            //Report builder
            IReportBuilder reportBuilder = new SalesReportBuilder();
            reportBuilder.SetTitle("Monthly report");
            reportBuilder.SetAuthor("Sergio");
            reportBuilder.SetSections(new List<string> { "sales", "..."});
            reportBuilder.SetDate();
            var report = reportBuilder.GetReport();
            report.DisplayReport();
            //Prints:
            //Report info:
            //Title: Monthly report
            //Date: 2 / 4 / 2024 18:30:00
            //Section 1: sales
            //Section 2: ...
            //Author: Sergio
        }
    }
}
