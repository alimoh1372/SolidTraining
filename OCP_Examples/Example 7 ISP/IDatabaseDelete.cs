using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.ISP
{
  public  interface IDatabaseDelete:IDatabase
    {
        void Delete();
    }
}
