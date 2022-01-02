using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderApp
{
    
    
		/// <summary>
		/// The company class
		/// </summary>
		class Company
		{
			public string CompanyName { get; set; }
			private List<Item> items = new List<Item>();
			private List<Customer> customers = new List<Customer>();

			/// <summary>
			/// Method to add new item
			/// </summary>
			/// <param name="item"></param>
			public void AddItem(Item item)
			{
				this.items.Add(item);
			}

			/// <summary>
			/// Method to get all items
			/// </summary>
			/// <returns></returns>
			public List<Item> GetItems()
			{
				return this.items;
			}

			/// <summary>
			/// Method to add customer
			/// </summary>
			/// <param name="customer"></param>
			public void AddCustomer(Customer customer)
			{
				this.customers.Add(customer);
			}

			/// <summary>
			/// Method to get all customers
			/// </summary>
			/// <returns></returns>
			public List<Customer> GetCustomers()
			{
				return this.customers;
			}
		}
}
