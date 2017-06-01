using CalculatorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        private IAddition _additionProvider;

        public Calculator(IAddition additionProvider)
        {
            _additionProvider = additionProvider;
        }

        public double Add(double x, double y)
        {
            return _additionProvider.Add(x, y);
        }
    }
}
