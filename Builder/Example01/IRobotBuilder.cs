namespace Builder.cs.Example01
{
    public interface IRobotBuilder
    {
        void BuildHead(string head);
        void BuildBody(string body);
        void BuildArms(string arms);
        void BuildLegs(string legs);
        Robot GetRobot();
    }
}
