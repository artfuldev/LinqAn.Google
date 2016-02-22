using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased.
	/// </summary>
	[Description("The total number of items purchased. For example, if users purchase 2 frisbees and 5 tennis balls, 7 items have been purchased.")]
	public class ItemQuantity: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ItemQuantity" />.
		/// </summary>
		public ItemQuantity(): base("Quantity",true,"ga:itemQuantity")
		{
			
		}
	}
}

