using CalculatorInterfaces;
using CalculatorLibrary;
using Microsoft.Practices.Unity;
using RegularAdditionImplementation;

namespace CompositionForLogging
{
    public class Composition
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
        public static Calculator GetCalculator()
        {
            return UnityContainer.Resolve<Calculator>();
        }
    }
}
