using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 5 refers the number/index of the custom metric. Note that the data type of ga:metric5 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 5 refers the number/index of the custom metric. Note that the data type of ga:metric5 can be INTEGER, CURRENCY or TIME.")]
	public class Metric5: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric5" />.
		/// </summary>
		public Metric5(): base("Custom Metric 5 Value",true,"ga:metric5")
		{
			
		}
	}
}

