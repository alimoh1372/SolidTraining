using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.DIP
{
   public class FileLogger:ILogger
    {
        public void Handle(string message)
        {
            Console.WriteLine($"The error({message})\nWrited To File");
        }
    }
}
