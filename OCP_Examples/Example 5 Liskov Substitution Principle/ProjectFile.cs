using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
   public class ProjectFile:ReadOnlyFile
    {
       

       
        public virtual void SaveData()
        {
            Console.WriteLine("The Data Saved...");
        }

    }
}
