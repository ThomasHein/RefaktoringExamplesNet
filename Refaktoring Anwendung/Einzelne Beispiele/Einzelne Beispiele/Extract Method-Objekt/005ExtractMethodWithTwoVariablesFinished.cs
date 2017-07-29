using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Extract_Method_Objekt
{
    public class PrintOwing
    {
        private ExtractMethodWithTwoVariables _extractMethodWithTwoVariables;
        private double _outstanding;
        private double _instanding;

        public PrintOwing(ExtractMethodWithTwoVariables extractMethodWithTwoVariables)
        {
            _extractMethodWithTwoVariables = extractMethodWithTwoVariables;
        }

        public void printOwing(IEnumerator<double> orders)
        {
            IEnumerator<double> e = orders;
            _outstanding = 0.0;
            _instanding = 0.0;
            _extractMethodWithTwoVariables.printBanner();
            // calculate outstanding
            while (e.Current>-1)
            {
                var each = CalculateEach(e);
                CalculateInstanding();
                CalculateOutstanding(each);
            }
            _extractMethodWithTwoVariables.printDetails(_outstanding);
            _extractMethodWithTwoVariables.printDetails(_instanding);
        }

        private void CalculateOutstanding(double each)
        {
            _outstanding += each;
        }

        private static double CalculateEach(IEnumerator<double> e)
        {
            double each = e.Current;
            each += new Random().Next();
            return each;
        }

        private void CalculateInstanding()
        {
            _instanding = _outstanding + new Random().Next();
        }
    }

    /// <summary>
    /// It's the assignment to local variables that becomes complicated. In this case we're only talking 
    /// about temps.If you see an assignment to a parameter, you should immediately use  Remove
    /// Assignments to Parameters.
    /// 
    /// For temps that are assigned to, there are two cases. The simpler case is that in which the 
    /// variable is a temporary variable used only within the extracted code.When that happens, you can
    /// move the temp into the extracted code.The other case is use of the variable outside the code.If
    /// the variable is not used after the code is extracted, you can make the change in just the extracted
    /// code.If it is used afterward, you need to make the extracted code return the changed value of the
    /// variable. I can illustrate this with the following method
    /// </summary>
    public class ExtractMethodWithTwoVariables
    {
        private IEnumerable<double> _orders;
        private readonly PrintOwing _printOwing;

        public ExtractMethodWithTwoVariables()
        {
            _printOwing = new PrintOwing(this);
        }

        public void printOwing()
        {
            _printOwing.printOwing(_orders.GetEnumerator());
        }

        public void printDetails(double outstanding)
        {
            Console.WriteLine($"Gesamtkosten {outstanding}");
        }

        public void printBanner()
        {
            // print banner
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes ******");
            Console.WriteLine("**************************");
        }
    }
}
