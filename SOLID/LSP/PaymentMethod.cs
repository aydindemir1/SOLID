using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public abstract class PaymentMethod
    {
        public abstract void ProcessPayment(decimal amount);
    }
}
