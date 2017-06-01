using Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation.Transactions
{
    public class DoubleTransactionGenerator : IDoubleTransactionGenerator
    {
        public IDoubleTransaction MakeDoubleTransaction(double firstValue, double secondValue, double returnValue)
        {
            return new DoubleTransaction { FirstValue = firstValue, SecondValue = secondValue, ResultReturned = returnValue };
        }
    }
}
