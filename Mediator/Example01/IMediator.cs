namespace Mediator.Example01
{
    public interface IMediator
    {
        void Notify(object sender, string eventCode);
    }
}
