namespace Mediator.Example01
{
    public class InvetorySystem
    {
        private IMediator _mediator;
        public InvetorySystem(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void CheckItemAvailability(string item)
        {
            Console.WriteLine($"Checking how many {item} are available...");
        }
    }
}
