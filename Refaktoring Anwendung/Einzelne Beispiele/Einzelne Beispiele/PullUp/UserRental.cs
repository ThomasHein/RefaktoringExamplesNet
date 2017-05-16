using System;
using System.Collections.Generic;
using System.Text;

namespace EinzelneBeispiele.FormTemplate
{
    public  class UserRental : SuperRental
    {
        private string title;

        public int Value { get; set; }

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
