using AbstractFactory.Example02.ConcreteClasses;

namespace AbstractFactory.Example02.Factories
{
    public class StripeFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new StripeGateway();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new StripeTransactionLogger();
        }
    }
}
