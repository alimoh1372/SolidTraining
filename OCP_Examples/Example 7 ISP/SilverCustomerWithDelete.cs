using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.ISP
{
    public class SilverCustomerWithDelete : CustomerWithDelete
    {
        public ISP.Customer _customer { get; set; }
        public SilverCustomerWithDelete(CustomerSilver customer)
        {
            _customer = customer;
        }
        public override void Add()
        {
            _customer.Add();
        }

        public override void Delete()
        {
            Console.WriteLine("Silver Customer With Delete Was Deleted....");
        }
    }
}
