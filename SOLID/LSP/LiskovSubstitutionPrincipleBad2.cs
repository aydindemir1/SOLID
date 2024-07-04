using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public class LiskovSubstitutionPrincipleBad2
    {
        public abstract class PaymentMethod
        {
            public abstract void ProcessPayment(decimal amount);
        }

        public class CreditCardPayment : PaymentMethod
        {
            public string CardNumber { get; set; }
            public string ExpiryDate { get; set; }

            public override void ProcessPayment(decimal amount)
            {
                Console.WriteLine($"Processing credit card payment of {amount:C}.");
            }
        }

        public class PayPalPayment : PaymentMethod
        {
            public string Email { get; set; }

            public override void ProcessPayment(decimal amount)
            {
                // PayPal ödemesi için farklı bir işlem süreci
                Console.WriteLine($"Processing PayPal payment of {amount:C}.");
            }
        }

        public class ShoppingCart
        {
            private readonly PaymentMethod _paymentMethod;

            public ShoppingCart(PaymentMethod paymentMethod)
            {
                _paymentMethod = paymentMethod;
            }

            public void Checkout(decimal amount)
            {
                _paymentMethod.ProcessPayment(amount);
            }
        }

        public class Program
        {
            public static void Main()
            {
                PaymentMethod paymentMethod = new PayPalPayment { Email = "example@domain.com" };
                ShoppingCart cart = new ShoppingCart(paymentMethod);
                cart.Checkout(100);

                // Çıkış: Processing PayPal payment of $100.00.

                paymentMethod = new CreditCardPayment { CardNumber = "1234-5678-9876-5432", ExpiryDate = "12/25" };
                cart = new ShoppingCart(paymentMethod);
                cart.Checkout(150);

                // Çıkış: Processing credit card payment of $150.00.
            }
        }

    }
}
