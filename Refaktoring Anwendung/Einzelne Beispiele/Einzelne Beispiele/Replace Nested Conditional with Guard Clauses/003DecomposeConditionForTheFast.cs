using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Replace_Nested_Conditional_with_Guard_Clauses
{
    public class _003DecomposeCondition
    {
        private object SUMMER_START;
        private object SUMMER_END;
        private double _winterRate;
        private double _winterServiceCharge;
        private double _summerRate;

        /*
         * Extract the condition into its own method.
·           Extract the then part and the else part into their own methods.
            ?? Was ist der Standardfall
        */
        public void aMethod(MyDateTime date, double quantity)
        {
            double charge=0;
            if (date.before(SUMMER_START) || date.after(SUMMER_END))
            {
                double specialRate = _winterRate * 2;
                if (date.after(SUMMER_END))
                {
                    charge = _winterRate+specialRate;
                }
                else if (date.before(SUMMER_START))
                {
                    charge = _winterRate;
                }
                if (date.isFriday() && charge > quantity * 3)
                {
                    charge = quantity * _winterRate + _winterServiceCharge;
                }
                charge += quantity * _winterRate + _winterServiceCharge;

            }
            else
            {
                charge = quantity * _summerRate;
            }
        }

    }

   
}
