using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.LSP
{
   public interface IDiscount
    {
        double GetDiscount(double totalPrice);
    }
}
