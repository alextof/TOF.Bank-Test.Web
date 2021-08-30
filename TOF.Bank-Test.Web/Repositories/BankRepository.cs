using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOF.Bank_Test.Model;
using TOF.Bank_Test.Web.Models;

namespace TOF.Bank_Test.Web.Repositories
{
    public class BankRepository
    {
        private readonly BankContext _context;
        public BankRepository(BankContext context)
        {
            _context = context;
        }

        public List<MovementListItemViewModel> GetAllMovements()
        {
            var list = _context.Transfers.ToList();
            var movements = list.Select(m => new MovementListItemViewModel()
            {
                Amount = m.Amount,
                Source = m.SourceAccount.AccountName,
                Target = m.DestinationAccount.AccountName
            }).ToList();

            return movements;
        }

        public bool AddTransfer(object/*AddTransferViewModel*/ transfer)
        {
            var isSuccessful = false;

            //TODO

            return isSuccessful;
        }
    }
}
