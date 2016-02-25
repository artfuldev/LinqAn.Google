using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 21 refers the number/index of the custom metric. Note that the data type of ga:metric21 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 21 refers the number/index of the custom metric. Note that the data type of ga:metric21 can be INTEGER, CURRENCY or TIME.")]
	public class Metric21: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric21" />.
		/// </summary>
		public Metric21(): base("Custom Metric 21 Value",true,"ga:metric21")
		{
			
		}
	}
}

