using BusinessCorpAdditionImplementation;
using CalculatorInterfaces;
using CalculatorLibrary;
using Data.Contracts;
using Data.Implementation.Transactions;
using Microsoft.Practices.Unity;
using RepositoryQueries;
using RepositoryQueryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionForLogging
{
    public class Composition
    {
        public static IUnityContainer UnityContainer;

        public static void InitializeContainer()
        {
            UnityContainer = new UnityContainer();
            // Register application dependencies here - this is the one place we're allowed to reference implementation classes.
            UnityContainer.RegisterType<IAddition, BusinessRequirementsAddition>();
            UnityContainer.RegisterType<ITransactionRepository, InMemoryTransactionRepository>();
            UnityContainer.RegisterType<IDoubleTransactionGenerator, DoubleTransactionGenerator>();
            UnityContainer.RegisterType<IReadOnlyTransactionQueries, ReadOnlyTransactionQueries>();
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

        public static IReadOnlyTransactionQueries GetQueries()
        {
            return UnityContainer.Resolve<IReadOnlyTransactionQueries>();
        }
    }
}
