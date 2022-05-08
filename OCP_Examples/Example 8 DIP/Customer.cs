using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.DIP
{
   public class Customer
    {
        private ILogger _logger { get; set; }
        public Customer(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            try
            {
                //Make some exeption
                int b = 10, c = 0;
                int a = b/c;
            }
            catch (Exception ex)
            {
                _logger.Handle(ex.Message);
            }
        }
    }
}
