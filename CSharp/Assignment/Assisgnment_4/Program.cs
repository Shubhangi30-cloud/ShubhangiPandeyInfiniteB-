using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisgnment_4
{ 
class Accounts
    {

        public int accountno;

        public string customername;

        public string accountype;

        public char transactiontype;

        public double amount;

        public double balance=0;

        public Accounts(int acno, string cname, string actype, char trantype, double amt)

        {

            accountno = acno;

            customername = cname;

            accountype = actype;

            transactiontype = trantype;

            amount = amt;

            if (transactiontype == 'D') 
            { 
                CreditAmount(amount); 
            } 
            else 
            {
                DebitAmount(amount);
            }

        }

        public void CreditAmount(double amount)

        {

            balance += amount;

        }

        public void DebitAmount(double amount)

        {

            if (balance > amount) 
            {
                balance -= amount;
            } 
            else 
            { 
                Console.WriteLine("insufficient balance...");  
             }

        }



        public void showData()

        {

            Console.WriteLine($"Account no : {accountno}");

            Console.WriteLine($"Customer name : {customername}");

            Console.WriteLine($"Account type : {accountype}");

            Console.WriteLine($"Transaction type : {transactiontype}");

            Console.WriteLine($"Amount : {amount}");

            Console.WriteLine($"Balance : {balance}");

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            Accounts accounts = new Accounts(12345, "harry potter", "saving", 'D', 30000);

            accounts.showData();

            Console.WriteLine(".............................");

            accounts = new Accounts(12345, "harry potter", "saving", 'w', 1000);

            accounts.showData();

            Console.ReadLine();

        }

    }
}
