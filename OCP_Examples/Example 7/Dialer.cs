using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
   public class Dialer
    {
        public void MakeCall(IDialable contact)
        {
            Console.WriteLine($"The call was maked with Telephone Number: {contact.Telephone} ....");
        }
    }
}
