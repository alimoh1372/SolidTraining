using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.DIP
{
   public class TransferManager
    {
        private ITransferSource _source { get; set; }
        private ITransferDestination _destination { get; set; }


        public TransferManager(ITransferSource sourceAccount,ITransferDestination destinationAccount)
        {
            _source = sourceAccount;
            _destination = destinationAccount;
        }

        public decimal value { get; set; }

        public void Transfer()
        {
            _source.RemoveFunds(value);
            _destination.AddFund(value);
        }
    }
}
