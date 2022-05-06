using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.ISP
{
  public abstract  class Customer:IDiscount,IDatabase
    {

        public virtual double GetDiscount(double totalPrice)
        {
            return totalPrice;
            //if (CustomerType==1)
            //{
            //    return totalPrice - 100;
            //}
            //else
            //{
            //    return totalPrice - 50;
            //}
        }
        public virtual void Add()
        {
            Console.WriteLine("The Customer Added...");
        }
    }
}
