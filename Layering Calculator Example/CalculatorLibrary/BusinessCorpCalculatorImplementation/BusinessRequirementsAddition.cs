using CalculatorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contracts;

namespace BusinessCorpAdditionImplementation
{
    /// <summary>
    /// For business-corp LLC we want our numbers fudged and are trying to convince our customers to use 'our' version of addition.
    /// We're also required to write a log of this transaction to a repository.
    /// </summary>
    public class BusinessRequirementsAddition : IAddition
    {
        private ITransactionRepository _transactionRepository;
        private IDoubleTransactionGenerator _doubleTransactionGenerator;

        public BusinessRequirementsAddition(ITransactionRepository transactionRepository, IDoubleTransactionGenerator doubleTransactionGenerator)
        {
            _transactionRepository = transactionRepository;
            _doubleTransactionGenerator = doubleTransactionGenerator;
        }

        public double Add(double x, double y)
        {
            double returnValue = x + y + y;
            // Single responsibility - we shouldn't be the ones generating the transaction nor should we be maintaining the repository. That's some someone else's job.
            _transactionRepository.AddTransaction(_doubleTransactionGenerator.MakeDoubleTransaction(x, y, returnValue));
            return returnValue;
        }
    }
}
