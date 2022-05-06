using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
  public  class Contact:IEmailable,IDialable
    {

        public string Name { get; set; }
        public string Address { get; set; }
        public string  Email { get; set; }

        public string Telephone { get; set; }

    }
}
