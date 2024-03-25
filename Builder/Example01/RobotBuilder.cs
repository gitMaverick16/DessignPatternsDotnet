namespace Builder.cs.Example01
{
    public class RobotBuilder : IRobotBuilder
    {
        private Robot _robot;
        public RobotBuilder()
        {
            _robot = new Robot();
        }
        public void BuildArms(string arms)
        {
            _robot.Arms = arms;
        }

        public void BuildBody(string body)
        {
            _robot.Body = body;
        }

        public void BuildHead(string head)
        {
            _robot.Head = head;
        }

        public void BuildLegs(string legs)
        {
            _robot.Legs = legs;
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
