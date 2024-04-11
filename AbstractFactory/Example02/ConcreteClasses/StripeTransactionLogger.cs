namespace AbstractFactory.Example02.ConcreteClasses
{
    public class StripeTransactionLogger : ITransactionLogger
    {
        public void Log()
        {
            Console.WriteLine("Stripe log");
        }
    }
}
