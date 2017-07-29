using EinzelneBeispiele.Replace_Nested_Conditional_with_Guard_Clauses;

namespace EinzelneBeispiele.ExtractClass
{
    public class PriceConditional
    {
        private _002ExtractClass _extractClass;

        public PriceConditional(_002ExtractClass extractClass)
        {
            _extractClass = extractClass;
        }

        public bool OnSeasonPrice(MyDateTime date)
        {
            return date.before(_extractClass.SUMMER_START);
        }

        public bool OffSeason(MyDateTime date)
        {
            return date.after(_extractClass.SUMMER_END);
        }

        public bool NotInSeason(MyDateTime date)
        {
            return date.before(_extractClass.SUMMER_START) || date.after(_extractClass.SUMMER_END);
        }
    }
}