namespace AbstractFactory.Example02.ConcreteClasses
{
    public class StripeGateway : IPaymentGateway
    {
        public void Pay()
        {
            Console.WriteLine("Stripe pay");
        }
    }
}
