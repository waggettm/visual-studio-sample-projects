﻿using CompositionForLogging;
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
        }
    }
}
