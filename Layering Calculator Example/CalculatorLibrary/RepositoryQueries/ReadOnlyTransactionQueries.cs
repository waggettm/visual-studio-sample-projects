using Data.Contracts;
using RepositoryQueryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryQueries
{
    public class ReadOnlyTransactionQueries : IReadOnlyTransactionQueries
    {
        private ITransactionRepository _transactionRepository;

        public ReadOnlyTransactionQueries(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public IEnumerable<IDoubleTransaction> GetAllTransactions()
        {
            return _transactionRepository.GetAllTransactions();
        }
    }
}
