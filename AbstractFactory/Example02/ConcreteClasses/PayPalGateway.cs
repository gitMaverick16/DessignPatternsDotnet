namespace AbstractFactory.Example02.ConcreteClasses
{
    public class PayPalGateway : IPaymentGateway
    {
        public void Pay()
        {
            Console.WriteLine("PayPal pay");
        }
    }
}
