using Builder.cs.Example01;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            IRobotBuilder builder = new RobotBuilder();
            builder.BuildHead("Round");
            builder.BuildBody("Metal");
            builder.BuildArms("Claws");
            builder.BuildLegs("Wheels");

            var robot = builder.GetRobot();
            robot.DisplayInfo();
        }
    }
}
