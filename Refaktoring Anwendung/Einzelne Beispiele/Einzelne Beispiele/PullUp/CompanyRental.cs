using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.FormTemplate
{
    public class CompanyRental : SuperRental
    {

        private string title;

        public void GetBillingForCustomer()
        {
            int amount = this.title.Length + GetBillingAmount(5);
        }

        public int GetBillingAmount(int NettoAmount)
        {
            return NettoAmount + 5;
        }
    }
}
