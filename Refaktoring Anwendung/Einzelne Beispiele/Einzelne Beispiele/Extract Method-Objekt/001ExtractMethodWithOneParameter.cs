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
    public class ExtractMethodWithOneParameter001
    {
        private IEnumerable<double> _orders;
        public void printOwing()
        {
            // Die Methode ist nicht verständlich. Zu viele unterschiedliche Aufgaben
            // Ziel Methode in die Bestandteile legen in der sie gehört
            IEnumerator<double> e = _orders.GetEnumerator();
            double outstanding = 0.0;
            // print banner
            Console.WriteLine("**************************");
            Console.WriteLine("***** Customer Owes ******");
            Console.WriteLine("**************************");
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

    }
}
