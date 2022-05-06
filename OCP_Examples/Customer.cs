using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
  public abstract  class Customer
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

    }
}
