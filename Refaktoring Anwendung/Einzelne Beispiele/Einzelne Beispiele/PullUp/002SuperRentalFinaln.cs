using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.FormTemplate
{
    public abstract class SuperRental1
    {
        public int GetBillingAmount(int NettoAmount)
        {
            return NettoAmount + 5;
        }
    }


    public class CompanyRental1 : SuperRental1
    {

        private string title;

        public void GetBillingForCustomer()
        {
            int amount = this.title.Length + GetBillingAmount(5);
        }

    }

    public class UserRental1 : SuperRental1
    {
        private string title;

        public int Value { get; set; }

        public void GetBillingForCustomer()
        {
            int amount = this.title.Length + GetBillingAmount(5);
        }
    }
}
