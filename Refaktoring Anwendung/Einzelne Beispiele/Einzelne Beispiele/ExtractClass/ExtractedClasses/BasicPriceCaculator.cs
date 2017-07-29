using EinzelneBeispiele.Replace_Nested_Conditional_with_Guard_Clauses;

namespace EinzelneBeispiele.ExtractClass
{
    public class BasicPriceCaculator
    {
        private _002ExtractClass _extractClass;
        private double _winterRate;
        private double _winterServiceCharge;
        private double _summerRate;

        public BasicPriceCaculator(_002ExtractClass extractClass)
        {
            _extractClass = extractClass;
        }

        public double GetNotInSeasonPrice(MyDateTime date, double quantity, double charge)
        {
            charge = GetChargeBasisPriceByNotInSeason(date, quantity, charge);
            charge += GetChargeExtraFee(quantity);
            return charge;
        }

        public  double GetSeasonPrice(double quantity)
        {
            return quantity * _summerRate;
        }

        private double GetChargeExtraFee(double quantity)
        {
            return quantity * _winterRate + _winterServiceCharge;
        }

        private double GetChargeBasisPriceByNotInSeason(MyDateTime date, double quantity, double charge)
        {
            if (_extractClass._priceConditional.OffSeason(date))
            {
                charge = OffSeasonPrice();
            }
            else if (_extractClass._priceConditional.OnSeasonPrice(date))
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

        private double OffSeasonPrice()
        {
            return _winterRate+SpecialRateForWinter();
        }

        private double SpecialRateForWinter()
        {
            return _winterRate * 2;
        }
    }
}