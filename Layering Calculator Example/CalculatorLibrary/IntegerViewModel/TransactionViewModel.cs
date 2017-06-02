using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class TransactionViewModel
    {
        public DoubleViewModel First { get; set; }
        public DoubleViewModel Second { get; set; }
        public DoubleViewModel Result { get; set; }

        public override string ToString()
        {
            return "User View Model:: First: " + First + " Second: " + Second + " Result: " + Result;
        }
    }
}
