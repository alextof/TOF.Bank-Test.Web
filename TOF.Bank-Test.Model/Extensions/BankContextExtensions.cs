using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOF.Bank_Test.Model.Extensions
{
    public static class BankContextExtensions
    {

        public static void Seed(this BankContext _context)
        {
            var nAccounts = 11;
            var rand = new Random();


            var accountList = new List<Account>()
            {
                new Account { Id = 1, AccountName = "ISIZ BV", Balance = 45450, CustomerType = CustomerType.Company },
                new Account { Id = 2, AccountName = "ISIZ Research Solutions", Balance = 124569.254, CustomerType = CustomerType.Company },
                new Account { Id = 3, AccountName = "BANK Account 0", Balance = 15495654, CustomerType = CustomerType.Company },
                new Account { Id = 4, AccountName = "Pedro Perez Parra", Balance = 6650.52544, CustomerType = CustomerType.Retail },
                new Account { Id = 5, AccountName = "Pablo Picasso Puntapie", Balance = 9854878.2, CustomerType = CustomerType.Private },
                new Account { Id = 6, AccountName = "Gerardo Gutierrez Garcia", Balance = 25.45, CustomerType = CustomerType.Retail },
                new Account { Id = 7, AccountName = "BANK Account 1", Balance = 6584774.12, CustomerType = CustomerType.Company },
                new Account { Id = 8, AccountName = "Alvaro Antunez Alvarez", Balance = 65484.54, CustomerType = CustomerType.Retail },
                new Account { Id = 9, AccountName = "Benedicto Bernardez Bahamonde", Balance = 454512.1, CustomerType = CustomerType.Retail },
                new Account { Id = 10, AccountName = "B188 Business Center", Balance = 564545.2, CustomerType = CustomerType.Company },
                new Account { Id = 11, AccountName = "Benedicto Bernardez Bahamonde", Balance = 654, CustomerType = CustomerType.Private }
            };

            _context.Accounts.AddRange(accountList);


            var transferList = new List<Transfer>();

            for (int i = 1; i < 100; i++)
            {

                transferList.Add(new Transfer
                {
                    SourceAccountId = rand.Next(nAccounts - 1) + 1,
                    DestinationAccountId = rand.Next(nAccounts - 1) + 1,
                    Amount = rand.NextDouble() * 100000,
                    MovementId = i

                });
            }

            _context.Transfers.AddRange(transferList);

            _context.SaveChanges();
        }
    }
}
