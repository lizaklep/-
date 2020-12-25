using System;
using System.Collections.Generic;

namespace Recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            /* try
             {
                Employee a = new Employee {Name = "dbhsj", Age = 18, Rezident = 12 };
             }
             catch(Minor ex)
             {
                Console.WriteLine($"Ошибка: {ex.Message}");
             }
             Console.Read();
            try
            {
                Employee a = new Employee { Name = "dbhsj",Rezident = 12 }; 
            }
            catch (Non_resident ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }*/

            List<Workers> workers = new List<Workers>();
            Work firm = new Work();
            Taker s = new Taker { Name = "Александр" };
            workers.Add(new Workers ("Иван", "иывр","Официант", (2015, 04, 02), (2019, 03, 24) ));
            Workers a1 = new Workers("Иван", "иывр", "Официант", (2015, 04, 02), (2019, 03, 24));
            firm.AddWorker(a1);
            a1.printExpiriense();
            a1.printLastWork();
            a1.printTaker();
            Random rdm = new Random();
            int i = rdm.Next(1,8);
            //a.LastWork = a.GetLastWork();

            //a.Print();

        }
    }
}
