using CalculatorLibrary;
using ConsoleCalculatorApp.Composition;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace ConsoleCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityComposition.InitializeContainer();
            var calculator = UnityComposition.UnityContainer.Resolve<Calculator>();
            
            // TODO: Make UI...
        }
    }
}
