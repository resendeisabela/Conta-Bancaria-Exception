using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExececaoContaBancaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double limit = double.Parse(Console.ReadLine());

            Account acc = new Account(number, holder, balance, limit);

            Console.Write("\nEnter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine());

            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New balance: "+acc.Balance.ToString("F2"));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw error: "+e.Message);
            }

            Console.ReadLine(); 
        }
    }
}
