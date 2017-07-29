using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Extract_Method_Objekt
{
    /// <summary>
    /// It's the assignment to local variables that becomes complicated. In this case we're only talking 
    /// about temps.If you see an assignment to a parameter, you should immediately use  Remove
    /// Assignments to Parameters.
    /// </summary>
    public class ExtractMethodWithOneParameter002
    {
        private IEnumerable<double> _orders;
        public void printOwing()
        {
            IEnumerator<double> e = _orders.GetEnumerator();
            double outstanding = 0.0;
            printBanner();
            // calculate outstanding
            while (e.Current>-1)
            {
                double each = e.Current;
                outstanding += each;
            }
            printDetails(outstanding);
        }

        private void printDetails(double outstanding)
        {
            Console.WriteLine($"Gesamtkosten {outstanding}");
        }

        private void printBanner()
        {
            // print banner
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes ******");
            Console.WriteLine("**************************");
        }
    }
}
