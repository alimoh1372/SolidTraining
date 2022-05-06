using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
    public class FileLogger : Ilogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{message}-write To the File");
        }
    }
}
