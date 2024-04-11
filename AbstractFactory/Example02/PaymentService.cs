using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Example02
{
    public class PaymentService
    {
        private readonly IPaymentGateway _paymentGateway;
        private readonly ITransactionLogger _transactionLogger;
        public PaymentService(IPaymentGatewayFactory paymentGatewayFactory)
        {
            _paymentGateway = paymentGatewayFactory.CreatePaymentGateway();
            _transactionLogger = paymentGatewayFactory.CreateTransactionLogger();
        }
        public void MakePayment()
        {
            _transactionLogger.Log();
            _paymentGateway.Pay();
        }
    }
}
