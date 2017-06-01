using CalculatorInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularAdditionImplementation
{
    /// <summary>
    /// No fancy business requirements for this guy, no logging, no wacky math, just regular addition.
    /// </summary>
    public class RegularAddition : IAddition
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
