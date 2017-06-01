using Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation.Transactions
{

    public class InMemoryTransactionRepository : ITransactionRepository
    {
        // In memory implementation - could easily be a service, database, etc..
        private HashSet<IDoubleTransaction> _transactions;

        public void AddTransaction(IDoubleTransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public IEnumerable<IDoubleTransaction> GetAllTransactions()
        {
            return _transactions;
        }
    }
}
