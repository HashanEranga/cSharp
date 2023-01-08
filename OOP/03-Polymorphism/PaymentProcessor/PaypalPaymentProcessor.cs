using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.PaymentProcessor
{
    public class PaypalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(PaymentData payment)
        {
            Console.WriteLine("Process Paypal Payments");
        }
    }
}
