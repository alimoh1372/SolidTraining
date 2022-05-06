using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
  public  class LogHandleing
    {
        private Ilogger _logger;

        public LogHandleing(Ilogger logger)
        {
            _logger = logger;
        }
       
        public void Log(string message)
        {
            _logger.Log(message);
        }
    }
}
