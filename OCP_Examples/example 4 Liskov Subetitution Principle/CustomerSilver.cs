using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.LSP
{
    public class CustomerSilver : Customer
    {
        public override double GetDiscount(double totalPrice)
        {
            return base.GetDiscount(totalPrice)-50;
        }
        public override void Add()
        {
            Console.WriteLine("The Silver Customer Added");
        }
    }
}
