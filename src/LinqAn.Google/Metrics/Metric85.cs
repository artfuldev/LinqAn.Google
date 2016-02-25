using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 85 refers the number/index of the custom metric. Note that the data type of ga:metric85 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 85 refers the number/index of the custom metric. Note that the data type of ga:metric85 can be INTEGER, CURRENCY or TIME.")]
	public class Metric85: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric85" />.
		/// </summary>
		public Metric85(): base("Custom Metric 85 Value",true,"ga:metric85")
		{
			
		}
	}
}

