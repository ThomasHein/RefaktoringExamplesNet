using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.Inline
{
    public class FurtherUsingClass
    {
        public void SomeTestMethod()
        {
            int vale = new MyInlineRental().GetValueHeavyCalculation(4,1);
        }
    }
}
