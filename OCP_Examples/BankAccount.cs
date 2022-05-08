using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples.DIP

{
   public class BankAccount:ITransferSource,ITransferDestination
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void AddFund(decimal value)
        {
            Balance += value;
            Console.WriteLine($"The value:{value} was Added to the destination Account {AccountNumber}");
        }
        public void RemoveFunds(decimal value)
        {
            Balance -= value;
            Console.WriteLine($"The value:{value} was Removed from the source Account {AccountNumber}");

        }

    }
}
