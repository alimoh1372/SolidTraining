using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.ISP
{
    public class GoldCustomerWithDelete : CustomerWithDelete
    {
        private IDatabase _customer { get; set; }
        
        public GoldCustomerWithDelete(CustomerGold customer)
        {
            _customer = customer;
        }

        public override void Add()
        {
            _customer.Add();
        }
        public override void Delete()
        {
            Console.WriteLine("The Gold Customer with deleted Was Delete...");
        }

    }
}
