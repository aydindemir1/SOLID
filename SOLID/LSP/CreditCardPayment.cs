using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class CreditCardPayment : PaymentMethod
    {
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }

        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing credit card payment of {amount:C}.");
        }
    }
}
