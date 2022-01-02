using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderApp
{
    class Order
    {
		public int OrderId { get; set; }
		private List<OrderItem> orderItems = new List<OrderItem>();
		public Customer Customer { get; set; }

		/// <summary>
		/// Method to add orderitem
		/// </summary>
		/// <param name="orderItem"></param>
		public void AddOrderItem(OrderItem orderItem)
		{
			this.orderItems.Add(orderItem);
		}

		/// <summary>
		/// Method to get orderitems
		/// </summary>
		/// <returns></returns>
		public List<OrderItem> GetOrderItems()
		{
			return this.orderItems;
		}

		/// <summary>
		/// Method to get total order value
		/// </summary>
		/// <returns></returns>
		public double GetTotalOrderValue()
		{
			double total = 0;
			foreach (var orderitem in orderItems)
			{
				total += orderitem.GetOrderItemValue();
			}
			return total;
		}

    }

}
