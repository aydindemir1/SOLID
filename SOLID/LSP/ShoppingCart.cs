using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
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
}
