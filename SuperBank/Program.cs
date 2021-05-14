using System;
using Newtonsoft.Json;

namespace SuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("David", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            account.MakeWithdrawal(120,DateTime.Now, "Hammock");
            Console.WriteLine(account.Balance);

            // For testing external dependencies we add this code ahead:

            string json = JsonConvert.SerializeObject(account);
            Console.WriteLine(json);
           

        }
    }
}
