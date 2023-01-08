using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism.PaymentProcessor
{
    public class PaymentData
    {
        public int Id { get; set; }
        public double PaymentAmount { get; set; }
        public double TaxAmount { get; set; }
        public int UserId { get; set; }
        public string? Currency { get; set; }

    }
}
