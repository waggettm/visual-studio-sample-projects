using Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Mapping
{
    public static class TransactionMapper
    {
        public static TransactionViewModel MapToTransactionViewModel(this IDoubleTransaction viewModel, IFormatProvider provider)
        {
            return new TransactionViewModel()
            {
                First = viewModel.FirstValue.MapToDoubleViewModel(provider),
                Second = viewModel.SecondValue.MapToDoubleViewModel(provider),
                Result = viewModel.ResultReturned.MapToDoubleViewModel(provider)
            };
        }
    }
}
