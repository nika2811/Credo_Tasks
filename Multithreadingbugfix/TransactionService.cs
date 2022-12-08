using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreadingbugfix
{
    internal class TransactionService
    {

    
        private readonly object _lockObject = new object();
        public void Transfer(BankAccount fromAccount, BankAccount toAccount, decimal amount)
        {
            lock (_lockObject)
            {
                if (amount > fromAccount.Balance)
                {
                    Console.WriteLine($"{fromAccount.Iban} has Insufficient funds");
                    return;
                }
                fromAccount.Balance -= amount;
                toAccount.Balance += amount;
            }
        }
    }


}
