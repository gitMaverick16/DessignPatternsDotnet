namespace AbstractFactory.Example02
{
    public interface IPaymentGatewayFactory
    {
        IPaymentGateway CreatePaymentGateway();
        ITransactionLogger CreateTransactionLogger();
    }
}
