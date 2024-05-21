namespace Mediator.Example02
{
    public class Airplane : Aircraft
    {
        public Airplane(IAirTrafficControl tower, string name) : base(tower, name)
        {
        }
    }
}
