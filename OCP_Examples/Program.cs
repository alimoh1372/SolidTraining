using System;
using System.Collections.Generic;
using OCP_Examples.LSP;
using OCP_Examples.ISP;

namespace OCP_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new CustomerGold();

            Console.WriteLine(customer.GetDiscount(10000));

            ConsoleLogger consoleLogger = new ConsoleLogger();
            LogHandleing logHandleing = new LogHandleing(consoleLogger);
            logHandleing.Log("Error Pardakht shode");
            FileLogger fileLogger = new FileLogger();
            logHandleing = new LogHandleing(fileLogger);
            fileLogger.Log("Error dar barname");


            PersianLang persianLang = new PersianLang();

            Hello hello = new Hello(persianLang);
            Console.WriteLine(hello.Say());


            Hello1 hello1 = new PersianLang1();
            Console.WriteLine(hello1.Say());

            Hello1 hello11 = new EnglishLang1();
            Console.WriteLine(hello11.Say());

            List<LSP.IDiscount> _customerCollection = new List<LSP.IDiscount>();
            _customerCollection.Add(new LSP.CustomerGold());
            _customerCollection.Add(new LSP.CustomerSilver());
            _customerCollection.Add(new LSP.BronzeCustomer());
            _customerCollection.Add(new LSP.LeadCustomer());


            foreach (LSP.IDiscount cust in _customerCollection)
            {
                Console.WriteLine(cust.GetDiscount(5000));
            }



            Project project = new Project();
            project.AllFiles.Add(new ProjectFile());
            project.readOnlyFiles.Add(new ReadOnlyFile());
            project.AllFiles.Add(new ProjectFile());
            project.AllFiles.Add(new ProjectFile());
            project.readOnlyFiles.Add(new ProjectFile());
            project.readOnlyFiles.Add(new ReadOnlyFile());


            project.LoadFiles();
            project.SaveFiels();





            Console.WriteLine("======================================================================");
            List<ISP.IDatabaseDelete> customerWithDeletes = new List<IDatabaseDelete>();
            customerWithDeletes.Add(new GoldCustomerWithDelete(new ISP.CustomerGold()));
            customerWithDeletes.Add(new SilverCustomerWithDelete(new ISP.CustomerSilver()));
            customerWithDeletes.Add(new SilverCustomerWithDelete(new ISP.CustomerSilver()));
            customerWithDeletes.Add(new SilverCustomerWithDelete(new ISP.CustomerSilver()));
            customerWithDeletes.Add(new GoldCustomerWithDelete(new ISP.CustomerGold()));
            customerWithDeletes.Add(new GoldCustomerWithDelete(new ISP.CustomerGold()));

            foreach (IDatabaseDelete customerWithDelete in customerWithDeletes)
            {
                customerWithDelete.Add();
                customerWithDelete.Delete();
            }

            List<ISP.IDatabase> customers = new List<ISP.IDatabase>();
            customers.Add(new ISP.CustomerSilver());
            customers.Add(new ISP.CustomerGold());
            customers.Add(new ISP.CustomerSilver());
            customers.Add(new ISP.CustomerSilver());
            customers.Add(new ISP.CustomerGold());
            customers.Add(new ISP.CustomerGold());

            foreach (ISP.IDatabase custom in customers)
            {
                custom.Add();
            }
            Console.WriteLine("======================================================================");

            Contact contact = new Contact
            {
                Name = "Ali Mohammadzade",
                Address = "Karaj",
                Email = "Alimohammadzade7976@gmail.com",
                Telephone = "09383738757"
            };
            Emailer emailer = new Emailer();
            emailer.SendMessage(contact, "Congragulation...", "This is the test Body");

            Engineer engineer = new Engineer()
            {
                Name = "Fateme Moradpoorian",
                Telephone = "09038438811"
            };
            
            Dialer dialer = new Dialer();
            dialer.MakeCall(contact);
            dialer.MakeCall(engineer);
            Console.ReadKey();
        }
    }
}
