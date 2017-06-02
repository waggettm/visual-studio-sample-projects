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
            return Double.Parse(viewModel.Value, viewModel.FormatProvider);
        }

        public static DoubleViewModel MapToDoubleViewModel(this double value, IFormatProvider formatProvider)
        {
            return new DoubleViewModel { Value = value.ToString(formatProvider), FormatProvider = formatProvider };
        }
    }
}
