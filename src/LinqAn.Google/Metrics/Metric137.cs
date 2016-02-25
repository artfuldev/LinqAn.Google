using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 137 refers the number/index of the custom metric. Note that the data type of ga:metric137 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 137 refers the number/index of the custom metric. Note that the data type of ga:metric137 can be INTEGER, CURRENCY or TIME.")]
	public class Metric137: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric137" />.
		/// </summary>
		public Metric137(): base("Custom Metric 137 Value",true,"ga:metric137")
		{
			
		}
	}
}

