using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.TempVariable
{
    class _001TempVariable
    {
        public double getPrice(int _quantity, double _itemPrice)
        {
            // hier haben wir sogar zwei Temporäre Variablen
            double basePrice = _quantity * _itemPrice;
            double discountFactor;
            if (basePrice > 1000)
                discountFactor = 0.95;
            else
                discountFactor = 0.98;
            return basePrice * discountFactor;
        }

        /**
         * Look for a temporary variable that is assigned to once.
             ? If a temp is set more than once consider Split Temporary Variable.
        ·  Declare the temp as final.
        ·  Compile.
             ? This will ensure that the temp is only assigned to once.  
        ·  Extract the right -hand side of the assignment into a method.
              ? Initially mark the method as private. You may find more use for it late r, 
        but you can easily relax the protection later.  
              ? Ensure the extracted method is free of side effects, that is, it does not 
        modify any object. If it is not free of side effects, use Separate Query  from Modifier . 
        ·  Compile and test.
        ·  Use Replace Temp with Queryon the temp.
         */
    }
}
