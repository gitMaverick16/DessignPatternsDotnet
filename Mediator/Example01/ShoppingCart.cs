namespace Mediator.Example01
{
    public class ShoppingCart
    {
        private IMediator _mediator;
        public ShoppingCart(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void AddItem(string item)
        {
            _mediator.Notify(this, item);
        }
    }
}
