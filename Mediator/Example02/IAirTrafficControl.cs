namespace Mediator.Example02
{
    public interface IAirTrafficControl
    {
        void SendMessage(Aircraft aircraft, string message);
    }
}
