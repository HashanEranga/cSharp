using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.PaymentProcessor
{
    public interface IPaymentValidator
    {
        public Boolean ValidatePayment();
    }
}
