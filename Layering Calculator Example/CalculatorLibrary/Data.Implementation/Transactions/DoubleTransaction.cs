using Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementation.Transactions
{
    public class DoubleTransaction : IDoubleTransaction
    {
        public double FirstValue { get; set; }
        public double SecondValue { get; set; }
        public double ResultReturned { get; set; }
    }
}
