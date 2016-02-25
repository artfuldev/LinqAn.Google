using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 142 refers the number/index of the custom metric. Note that the data type of ga:metric142 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 142 refers the number/index of the custom metric. Note that the data type of ga:metric142 can be INTEGER, CURRENCY or TIME.")]
	public class Metric142: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric142" />.
		/// </summary>
		public Metric142(): base("Custom Metric 142 Value",true,"ga:metric142")
		{
			
		}
	}
}

