using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Replace_Nested_Conditional_with_Guard_Clauses
{
    public class _001DecomposeCondition
    {
        private object SUMMER_START;
        private object SUMMER_END;
        private double _winterRate;
        private double _winterServiceCharge;
        private double _summerRate;

        /*
         * Extract the condition into its own method.
·           Extract the then part and the else part into their own methods.
        */
        public void aMethod(MyDateTime date, double quantity)
        {
            double charge;
            if (date.before(SUMMER_START) || date.after(SUMMER_END))
                charge = quantity * _winterRate + _winterServiceCharge;
            else charge = quantity * _summerRate;
        }

    }

    public class MyDateTime
    {
        public bool before(object summerStart)
        {
            throw new NotImplementedException();
        }

        public bool after(object summerEnd)
        {
            throw new NotImplementedException();
        }

        public bool isFriday()
        {
            throw new NotImplementedException();
        }
    }
}
