namespace CompanyOrderApp
{
    class OrderItem
    {
		public Item Item { get; set; }
		public int Qty { get; set; }

		/// <summary>
		/// Method to get order item value.
		/// </summary>
		/// <returns></returns>
		public double GetOrderItemValue()
		{
			return Item.Price * Qty;
		}
	}
}