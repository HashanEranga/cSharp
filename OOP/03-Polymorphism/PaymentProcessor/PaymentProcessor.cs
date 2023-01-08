using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.PaymentProcessor
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(PaymentData payment);
        public void SomeDefaultMethod()
        {
            Console.WriteLine("This is a default method");
        }
        public static void SomeStaticMethod()
        {
            Console.WriteLine("Some static method");
        }

    }
}
