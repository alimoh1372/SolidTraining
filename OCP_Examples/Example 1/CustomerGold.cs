using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
    public class CustomerGold : Customer
    {
        public override double GetDiscount(double totalPrice)
        {
            return base.GetDiscount(totalPrice) - 100;
        }
    }
}
