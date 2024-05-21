namespace Mediator.Example02
{
    public class Helicopter : Aircraft
    {
        public Helicopter(IAirTrafficControl tower, string name) : base(tower, name)
        {
        }
    }
}
