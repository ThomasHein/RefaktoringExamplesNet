using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Replace_Nested_Conditional_with_Guard_Clauses
{
    public class _001ExtractClass
    {
        private object SUMMER_START;
        private object SUMMER_END;
        private double _winterRate;
        private double _winterServiceCharge;
        private double _summerRate;

        /*
         * Decide howto split the responsibilities of the class.
        ·  Create a new class to express the split-off responsibilities.
        ?rarr; If the responsibilities of the old class no longer match its name, 
        rename the old class.
        ·  Make a link from the old to the new class.
        ?rarr; You may need a two-way link. But don't make the back link until 
        you find you need it. 
        ·  Use Move Fieldon each field you wish to move.
        ·  Compile and test after each move.
        ·  Use Move Methodto move methods over from old to new. Start with lower-level 
        methods (called rather than calling) and build to the higher level.
        ·  Compile and test after each move.
        ·  Review and reduce the interfaces of each class.
        ?rarr; If you did have a two -way link, examine to see whether it can be 
        made one way.
        ·  Decide whether to expose the new class. If you do expose the class, decide whether to 
        expose it as a reference object or as an immutable value object. 
        */
        public void aMethod(MyDateTime date, double quantity)
        {
            double charge=0;
            if (NotInSeason(date))
            {
                charge = GetNotInSeasonPrice(date, quantity, charge);
            }
            else
            {
                charge = GetSeasonPrice(quantity);
            }
        }

        private double GetNotInSeasonPrice(MyDateTime date, double quantity, double charge)
        {
            charge = GetChargeBasisPriceByNotInSeason(date, quantity, charge);
            charge += GetChargeExtraFee(quantity);
            return charge;
        }

        private double GetSeasonPrice(double quantity)
        {
            return quantity * _summerRate;
        }

        private double GetChargeExtraFee(double quantity)
        {
            return quantity * _winterRate + _winterServiceCharge;
        }

        private double GetChargeBasisPriceByNotInSeason(MyDateTime date, double quantity, double charge)
        {
            if (OffSeason(date))
            {
                charge = OffSeasonPrice();
            }
            else if (OnSeasonPrice(date))
            {
                charge = _winterRate;
            }
            if (IsBonusDay(date, quantity, charge))
            {
                charge = BonusDayCharge(quantity);
            }
            return charge;
        }

        private double BonusDayCharge(double quantity)
        {
            return quantity * _winterRate + _winterServiceCharge;
        }

        private static bool IsBonusDay(MyDateTime date, double quantity, double charge)
        {
            return date.isFriday() && charge > quantity * 3;
        }

        private bool OnSeasonPrice(MyDateTime date)
        {
            return date.before(SUMMER_START);
        }

        private double OffSeasonPrice()
        {
            return _winterRate+SpecialRateForWinter();
        }

        private bool OffSeason(MyDateTime date)
        {
            return date.after(SUMMER_END);
        }

        private double SpecialRateForWinter()
        {
            return _winterRate * 2;
        }

        private bool NotInSeason(MyDateTime date)
        {
            return date.before(SUMMER_START) || date.after(SUMMER_END);
        }
    }

   
}
