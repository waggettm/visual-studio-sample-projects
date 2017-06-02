using Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryQueryInterfaces
{
    public interface IReadOnlyTransactionQueries
    {
        IEnumerable<IDoubleTransaction> GetAllTransactions();
    }
}
