using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.PaymentProcessor
{
    public class ChasePaymentProcessor : IPaymentProcessor, IPaymentValidator
    {
        public void ProcessPayment(PaymentData payment)
        {
            Console.WriteLine("Chase payment processor selected");
        }

        public bool ValidatePayment()
        {
            Console.WriteLine("Chase Payment Validated");
            return true;
        }
    }
}
