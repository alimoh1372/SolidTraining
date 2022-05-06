using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Examples
{
  public class Emailer
    {
       public void SendMessage(IEmailable contact,string subject,string body)
        {
            Console.WriteLine($"The Email Was Send to Email Address:{contact.Email} for {contact.Name}");
        }
    }
}
