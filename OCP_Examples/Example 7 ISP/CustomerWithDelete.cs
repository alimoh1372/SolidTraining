using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.ISP
{
    public abstract class CustomerWithDelete : IDatabaseDelete
    {
        
        public virtual void Add()
        {
            Console.WriteLine("Customer with Delete was added....");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Customer with Delete Was Deleted...");
        }
    }
}
