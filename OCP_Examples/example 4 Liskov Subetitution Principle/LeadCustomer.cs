using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.LSP
{
    public class LeadCustomer:IDiscount
    {
        public  double GetDiscount(double totalPrice)
        {
            return totalPrice-10;
        }
        //public override void Add()
        //{
        //    throw new Exception("Not Allowed To add");
        //}
    }
}
