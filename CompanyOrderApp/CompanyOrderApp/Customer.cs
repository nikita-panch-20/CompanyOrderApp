using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderApp
{
    class Customer
    {
		public string CustomerName { get; set; }
		private List<Company> companies = new List<Company>();
		private List<Order> orders = new List<Order>();

		/// <summary>
		/// Method to get Total Order Value.
		/// </summary>
		/// <returns></returns>
		public virtual double GetTotalCustomerValue()
		{
			double total = 0;
			foreach (var order in orders)
			{
				total += order.GetTotalOrderValue();
			}
			return total;
		}


		/// <summary>
		/// Method to add company
		/// </summary>
		/// <param name="company"></param>
		public void AddCompany(Company company)
		{
			this.companies.Add(company);
		}

		/// <summary>
		/// Method to get companies
		/// </summary>
		/// <returns></returns>
		public List<Company> GetCompanies()
		{
			return this.companies;
		}

		/// <summary>
		/// Method to add order
		/// </summary>
		/// <param name="order"></param>
		public void AddOrder(Order order)
		{
			this.orders.Add(order);
		}

		/// <summary>
		/// Method to get orders
		/// </summary>
		/// <returns></returns>
		public List<Order> GetOrders()
		{
			return this.orders;
		}
	}
}
