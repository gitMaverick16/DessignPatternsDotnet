namespace Mediator.Example01
{
    public class EcommercePlatform : IMediator
    {
        private ShoppingCart _shoppingCart;
        private InvetorySystem _invetorySystem;
        public EcommercePlatform(ShoppingCart shoppingCart, 
            InvetorySystem invetorySystem)
        {
            _shoppingCart = shoppingCart;
            _invetorySystem = invetorySystem;
        }
        public void Notify(object sender, string eventCode)
        {
            if(sender is ShoppingCart)
            {
                _invetorySystem.CheckItemAvailability(eventCode);
            }
        }
    }
}
