using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 4 refers the number/index of the custom metric. Note that the data type of ga:metric4 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 4 refers the number/index of the custom metric. Note that the data type of ga:metric4 can be INTEGER, CURRENCY or TIME.")]
	public class Metric4: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric4" />.
		/// </summary>
		public Metric4(): base("Custom Metric 4 Value",true,"ga:metric4")
		{
			
		}
	}
}

