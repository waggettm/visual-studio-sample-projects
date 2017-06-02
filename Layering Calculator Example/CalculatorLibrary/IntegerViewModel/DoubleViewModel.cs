using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class DoubleViewModel
    {
        public string Value { get; set; }
        public IFormatProvider FormatProvider { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
