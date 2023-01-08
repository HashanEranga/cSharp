using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.PaymentProcessor
{
    public class Client
    {
        private IPaymentProcessor paymentProcessor = new PaypalPaymentProcessor();

        public void CheckOut(PaymentData payment)
        {
            Console.WriteLine("Checking out");
            paymentProcessor.ProcessPayment(payment);
            IPaymentProcessor.SomeStaticMethod();
        }

        public void SetPaymentProcessor(IPaymentProcessor _paymentProcessor)
        {
            Console.WriteLine("Set Payment Processor Clicked");
            paymentProcessor = _paymentProcessor;
        }
    }
}
