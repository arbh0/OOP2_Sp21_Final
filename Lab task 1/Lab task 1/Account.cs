using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_task_1
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; set; }
        public double Balance { get; set; }

        public int totalNumberOfTransaction { get; set; }

        Transaction[] listOfTransaction;

        public Account()
        {
            listOfTransaction = new Transaction[20];

        }
        public Account(string accName, string accNo, double balance)
        {
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            listOfTransaction = new Transaction[20];
            Console.WriteLine("Account Created");
            ShowInfo();

        }

        public void AddTransaction(Transaction transactions)
        {

            this.listOfTransaction[totalNumberOfTransaction++] = transactions;

        }

        public void ShowAllTransaction()
        {
            for (int i = 0; i < totalNumberOfTransaction; i++)
            {
                listOfTransaction[i].ShowInfo();
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Amount Deposited = {0}", amount);
            ShowInfo();
        }

        virtual public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Amount Withdrawn = {0}", amount);
                ShowInfo();
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        virtual public void Transfer(Account acc, int amount)
        {
            if (amount <= Balance)
            {
                this.Balance -= amount;
                acc.Balance += amount;
                Console.WriteLine("{0} Taka Has Been Transferred To {1}({2}) From {3}({4}).", amount, acc.AccName, acc.AccNo,this.AccName,this.AccNo);
                Transaction t = new Transaction(this, acc, amount, "Money Transfer");
                this.AddTransaction(t);
                acc.AddTransaction(t);
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Account Name: " + AccName);
            Console.WriteLine("Account No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("------------------------------------------------");
        }
    }
    
}
