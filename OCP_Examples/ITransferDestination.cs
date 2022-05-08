using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.DIP
{
  public interface ITransferDestination
    {
        void AddFund(decimal value);
    }
}
