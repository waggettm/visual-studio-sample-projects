using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace ViewModels.Mapping
{
    public static class DoubleMapper
    {
        public static double MapToDouble(this DoubleViewModel viewModel)
        {
            return viewModel.Value;
        }

        public static DoubleViewModel MapToDoubleViewModel(this double value, IFormatProvider formatProvider)
        {
            return new DoubleViewModel { FormatProvider = formatProvider, Value = value };
        }
    }
}
