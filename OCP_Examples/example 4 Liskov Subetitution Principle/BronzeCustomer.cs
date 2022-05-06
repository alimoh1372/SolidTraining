using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.LSP
{
   public class BronzeCustomer:Customer
    {
        public override double GetDiscount(double totalPrice)
        {
            return base.GetDiscount(totalPrice)-30;
        }
        public override void Add()
        {
            Console.WriteLine("The Bronze Customer Added");
        }
    }
}
