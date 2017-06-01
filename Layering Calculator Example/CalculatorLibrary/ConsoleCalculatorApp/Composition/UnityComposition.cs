using CalculatorInterfaces;
using CalculatorLibrary;
using Microsoft.Practices.Unity;
using RegularAdditionImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorApp.Composition
{
    public static class UnityComposition
    {
        public static IUnityContainer UnityContainer;

        public static void InitializeContainer()
        {
            UnityContainer = new UnityContainer();
            // Register application dependencies here - this is the one place we're allowed to reference implementation classes.
            UnityContainer.RegisterType<IAddition, RegularAddition>();
            UnityContainer.RegisterType<Calculator>();
        }

        public static void DisposeContainer()
        {
            UnityContainer.Dispose();
        }
    }
}
