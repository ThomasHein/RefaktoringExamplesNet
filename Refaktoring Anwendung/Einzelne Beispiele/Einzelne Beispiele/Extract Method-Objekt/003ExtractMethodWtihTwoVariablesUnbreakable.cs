using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Extract_Method_Objekt
{
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
    public class ExtractMethodWtihTwoVariablesFinished
    {
        private IEnumerable<double> _orders;
        public void printOwing()
        {
            IEnumerator<double> e = _orders.GetEnumerator();
            double outstanding = 0.0; // not good
            double instanding = 0.0; // not good
            printBanner();
            // calculate outstanding
            // Ziel die Berechnung ind er Schleife soll ausgelagert werden. Wie mache ich das
            while (e.Current>-1)
            {
                double each = e.Current;
                each += new Random().Next();
                instanding = outstanding + new Random().Next();
                outstanding += each;
            }
            printDetails(outstanding);
            printDetails(instanding);
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

        /*
         * Create a new class, name it after the method.
        ·  Give the new class a final field for the object that hosted the original method (the source  object) and a field for each temporary variable and each parameter in the method.
        ·  Give the new class a constructor that takes the source object and each parameter.
        ·  Give the new class a method named "compute." 
        ·  Copy the body of the original method into compute. Use the source object field for any inv ocations of methods on the original object.
        ·  Compile.
        ·  Replace the old method with one that creates the new object and calls compute
        ·  Refactor the Method

         */
    }
}
