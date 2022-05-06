using System;

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
            Console.ReadKey();
        }
    }
}
