using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.DIP
{
    public class EmailLogger : DIP.ILogger
    {
        public void Handle(string message)
        {
            Console.WriteLine($"The error({message})\nSent To Email(logged into email)...");
        }
    }
}
