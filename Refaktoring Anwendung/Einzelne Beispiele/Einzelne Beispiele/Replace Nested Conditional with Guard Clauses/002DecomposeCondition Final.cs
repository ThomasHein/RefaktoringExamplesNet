using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Replace_Nested_Conditional_with_Guard_Clauses
{
    public class _002DecomposeCondition
    {
        private object SUMMER_START;
        private object SUMMER_END;
        private double _winterRate;
        private double _winterServiceCharge;
        private double _summerRate;

        /*
         * Extract the condition into its own method.
·           Extract the then part and the else part into their own methods.
            ?? Was ist der Standardfall - Anscheind der Elsezweig
        */
        public void aMethod(MyDateTime date, double quantity)
        {
            double charge;
            if (DateNotIinSesaon(date))
                charge = WinterCharge(quantity);
            else
                charge = SeasonCharge(quantity);
        }

        private double SeasonCharge(double quantity)
        {
            return quantity * _summerRate;
        }

        private double WinterCharge(double quantity)
        {
            return quantity * _winterRate + _winterServiceCharge;
        }

        private bool DateNotIinSesaon(MyDateTime date)
        {
            return date.before(SUMMER_START) || date.after(SUMMER_END);
        }
    }

   
}
