using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderApp
{
    
    
		/// <summary>
		/// The RegCustomer class
		/// </summary>
		class RegCustomer : Customer
		{
			public int Discount { get; set; } = 10;
        public override double GetTotalCustomerValue()
        {
            double totalCustomerValue = base.GetTotalCustomerValue();
            double total = totalCustomerValue - totalCustomerValue * Discount / 100;
            return total;
        }
    }
	
}
