using AbstractFactory.Example02.ConcreteClasses;

namespace AbstractFactory.Example02.Factories
{
    public class PayPalFactory : IPaymentGatewayFactory
    {
        public IPaymentGateway CreatePaymentGateway()
        {
            return new PayPalGateway();
        }

        public ITransactionLogger CreateTransactionLogger()
        {
            return new PayPalTransactionLogger();
        }
    }
}
