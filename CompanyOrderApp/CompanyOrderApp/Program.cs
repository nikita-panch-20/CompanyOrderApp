using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderApp
{
    class Program
    {
		static void Main(string[] args)
		{
			//1. Create items
			Item item1 = new Item() { Name = "SS Note 4S", Price = 15000 };
			Item item2 = new Item() { Name = "SS Note 4", Price = 25000 };
			Item item3 = new Item() { Name = "iPhone 11", Price = 15000 };
			Item item4 = new Item() { Name = "iPhone 10", Price = 7500 };
			Item item5 = new Item() { Name = "Nokia K5", Price = 25000 };

			//2. Create company
			Company company = new Company() { CompanyName = "Shop-On" };

			//3. Add items to company
			company.AddItem(item1);
			company.AddItem(item2);
			company.AddItem(item3);
			company.AddItem(item4);
			company.AddItem(item5);

			//4. Create customer
			Customer customer1 = new Customer() { CustomerName = "Ravi" };
			Customer customer2 = new Customer() { CustomerName = "Shiva" };
			Customer customer3 = new RegCustomer() { CustomerName = "Shashi" };

			//5. Add customer to company
			company.AddCustomer(customer1);
			company.AddCustomer(customer2);
			company.AddCustomer(customer3);

			//6. Add company to customer
			customer1.AddCompany(company);
			customer2.AddCompany(company);
			customer3.AddCompany(company);

			//7. Create order
			Order order1 = new Order() { OrderId = 10001 };
			Order order2 = new Order() { OrderId = 10002 };
			Order order3 = new Order() { OrderId = 10003 };
			Order order4 = new Order() { OrderId = 10004 };
			Order order5 = new Order() { OrderId = 10005 };
			Order order6 = new Order() { OrderId = 10006 };

			//8. Add order to customer
			customer1.AddOrder(order1);
			customer1.AddOrder(order2);
			customer2.AddOrder(order3);
			customer3.AddOrder(order4);
			customer3.AddOrder(order5);
			customer3.AddOrder(order6);

			//9. Add customer to order
			order1.Customer = customer1;
			order2.Customer = customer1;
			order3.Customer = customer2;
			order4.Customer = customer3;
			order5.Customer = customer3;
			order6.Customer = customer3;

			//10. Create Orderitem
			OrderItem orderitem1 = new OrderItem() { Qty = 1 };
			OrderItem orderitem2 = new OrderItem() { Qty = 1 };
			OrderItem orderitem3 = new OrderItem() { Qty = 2 };
			OrderItem orderitem4 = new OrderItem() { Qty = 2 };
			OrderItem orderitem5 = new OrderItem() { Qty = 3 };
			OrderItem orderitem6 = new OrderItem() { Qty = 1 };
			OrderItem orderitem7 = new OrderItem() { Qty = 2 };
			OrderItem orderitem8 = new OrderItem() { Qty = 3 };
			OrderItem orderitem9 = new OrderItem() { Qty = 1 };
			OrderItem orderitem10 = new OrderItem() { Qty = 2 };

			//11. Add item to orderitem
			orderitem1.Item = item1;
			orderitem2.Item = item2;
			orderitem3.Item = item3;
			orderitem4.Item = item4;
			orderitem5.Item = item1;
			orderitem6.Item = item4;
			orderitem7.Item = item2;
			orderitem8.Item = item5;
			orderitem9.Item = item2;
			orderitem10.Item = item5;

			//12. Add orderitem to order
			order1.AddOrderItem(orderitem1);
			order1.AddOrderItem(orderitem2);
			order2.AddOrderItem(orderitem3);
			order2.AddOrderItem(orderitem4);
			order3.AddOrderItem(orderitem5);
			order4.AddOrderItem(orderitem6);
			order4.AddOrderItem(orderitem7);
			order5.AddOrderItem(orderitem8);
			order5.AddOrderItem(orderitem9);
			order6.AddOrderItem(orderitem10);

			//13. Display Company Details
			DisplayCompanyInfo(company);
		}
		private static void DisplayCompanyInfo(Company company)
		{
			double companyTotal = 0;
			double total = 0;
			double totalCustomerValue = 0;
			Console.WriteLine("Company Info " + company.CompanyName);
			DrawLine();
			Console.WriteLine("Customer Info:");
			DrawLine();
			foreach (var customer in company.GetCustomers())
			{
				totalCustomerValue = 0;
				Console.WriteLine($"Customer Name : " + customer.CustomerName);
				DrawLine();
				foreach (var order in customer.GetOrders())
				{
					total = 0;
					Console.WriteLine($"Order ID : {order.OrderId}");
					DrawLine();
					Console.WriteLine("Item Name \t Price \t Qty \t Total");
					DrawLine();
					foreach (var orderitem in order.GetOrderItems())
					{
						Console.WriteLine($"{orderitem.Item.Name} \t " +
							$"{orderitem.Item.Price} \t " +
							$"{orderitem.Qty} \t" +
							$"{orderitem.GetOrderItemValue()}");
						//total = total + orderitem.Item.Price * orderitem.Qty;
						companyTotal = companyTotal + orderitem.Item.Price * orderitem.Qty;
					}
					//totalCustomerValue = totalCustomerValue + total;
					DrawLine();
					Console.WriteLine("\t\tTotal Amount : " + order.GetTotalOrderValue());
					DrawLine();
				}
				DrawLine();
				total = customer.GetTotalCustomerValue();
				if (customer is RegCustomer)
				{
					RegCustomer regCustomer = (RegCustomer)customer;
					int discout = regCustomer.Discount;
					double amountAfterDiscout = customer.GetTotalCustomerValue() - (customer.GetTotalCustomerValue() * discout / 100);
					//Console.WriteLine("Total Customer Value : " + amountAfterDiscout);
					total = amountAfterDiscout;
				}
				Console.WriteLine("Total Customer Value : " + total);
				/*
				else
				{					
					Console.WriteLine("Total Customer Value : " + customer.GetTotalCustomerValue());
				}*/

			}
			DrawLine();
			Console.WriteLine("Grand Total Amount : " + companyTotal);
			Console.ReadLine();
		}

		private static void DrawLine()
		{
			Console.WriteLine();
			for (int i = 0; i < 40; i++)
			{
				Console.Write("-");
			}
			Console.WriteLine();
		}
	}
}
