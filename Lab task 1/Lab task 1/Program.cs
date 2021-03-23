using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------------");
            Account a1 = new Account("Razib", "111", 100000);
            Account a2 = new Account("Fahim", "222", 30000);

            a1.Deposit(20000);
            a1.Withdraw(1000);
            a1.Transfer(a2, 10000);
            a1.ShowAllTransaction();
            Console.WriteLine("------------------------------------------------");
            a2.Transfer(a1, 5000);
            a2.ShowAllTransaction();
            Console.WriteLine("------------------------------------------------");
            a1.ShowInfo();
            a2.ShowInfo();
            Console.ReadLine();
        }
    }
}
