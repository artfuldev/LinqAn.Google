using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 156 refers the number/index of the custom metric. Note that the data type of ga:metric156 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 156 refers the number/index of the custom metric. Note that the data type of ga:metric156 can be INTEGER, CURRENCY or TIME.")]
	public class Metric156: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric156" />.
		/// </summary>
		public Metric156(): base("Custom Metric 156 Value",true,"ga:metric156")
		{
			
		}
	}
}

