using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInterfaces
{
    /// <summary>
    /// Interface segregation principle - we want IAddition, not IMath
    /// </summary>
    public interface IAddition
    {
        double Add(double x, double y);
    }
}
