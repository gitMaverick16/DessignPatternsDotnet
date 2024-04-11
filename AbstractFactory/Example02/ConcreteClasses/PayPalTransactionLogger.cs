namespace AbstractFactory.Example02.ConcreteClasses
{
    public class PayPalTransactionLogger : ITransactionLogger
    {
        public void Log()
        {
            Console.WriteLine("PayPal log");
        }
    }
}
