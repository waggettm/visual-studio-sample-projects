using CompositionForLogging;
using Data.Contracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using ViewModels.Mapping;

namespace ConsoleCalculatorAppWithLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            // Must occur first! Initializes the IoC container so we can get the calculator properly.
            Composition.InitializeContainer();
            var calculator = Composition.GetCalculator();

            var currentUserCulture = new CultureInfo("en-US");

            var first = new DoubleViewModel { Value = "4.2", FormatProvider = currentUserCulture };
            var second = new DoubleViewModel { Value = "2.4", FormatProvider = currentUserCulture };

            Console.WriteLine(calculator.Add(first.MapToDouble(), second.MapToDouble()).MapToDoubleViewModel(currentUserCulture));

            // Mimic the user changing locale
            currentUserCulture = new CultureInfo("fr-FR");

            first = new DoubleViewModel { Value = "1,5", FormatProvider = currentUserCulture };
            second = new DoubleViewModel { Value = "2,6", FormatProvider = currentUserCulture };

            Console.WriteLine(calculator.Add(first.MapToDouble(), second.MapToDouble()).MapToDoubleViewModel(currentUserCulture));

            var queries = Composition.GetQueries();

            foreach (var transaction in queries.GetAllTransactions())
            {
                // User view of the data
                Console.WriteLine(transaction.MapToTransactionViewModel(currentUserCulture));

                // Stored persisted version of the data - demonstrates data representation as persisted does not need to match what's shown to the user.
                Console.WriteLine(DataTransactionContents(transaction));
            }
        }

        private static string DataTransactionContents(IDoubleTransaction transaction)
        {
            return "Data Transaction Record:: First: " + transaction.FirstValue + " Second: " + transaction.SecondValue + " Result: " + transaction.ResultReturned;
        }
    }
}
