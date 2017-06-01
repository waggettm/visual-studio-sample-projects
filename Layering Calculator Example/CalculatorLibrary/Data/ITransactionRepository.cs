using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contracts
{
    public interface ITransactionRepository
    {
        void AddTransaction(IDoubleTransaction transaction);
        IEnumerable<IDoubleTransaction> GetAllTransactions();
    }
}
