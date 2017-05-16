using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Inline
{
    public class MyInlineRental
    {
        public int GetValueHeavyCalculation(int a, int b)
        {

            int rand = new Random().Next();
            int result = Math.Max(rand * (a + b), Math.Max(rand * a * 10,Math.Max( rand * b * 10, 12)));
            return result;
        }

        public void CustomerOneCalculation()
        {
            int value = GetValueHeavyCalculation(1, 3);
        }

        public void CustomterTwoCalculation()
        {
            int value = GetValueHeavyCalculation(4, 3);
        }
    }
}
