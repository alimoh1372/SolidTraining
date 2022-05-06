using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
   public class ReadOnlyFile
    {
        public string FilePath { get; set; }
        public byte[] FileData { get; set; }
        //Befor implement LSP
        public virtual void LoadData()
        {
            Console.WriteLine("The Data loaded...");
        }
    }
}
