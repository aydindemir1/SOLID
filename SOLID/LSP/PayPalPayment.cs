using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class PayPalPayment : PaymentMethod
    {
        public string Email { get; set; }

        public override void ProcessPayment(decimal amount)
        {
            // PayPal ödemesi için farklı bir işlem süreci
            Console.WriteLine($"Processing PayPal payment of {amount:C}.");
        }
    }
}
