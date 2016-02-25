using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 37 refers the number/index of the custom metric. Note that the data type of ga:metric37 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 37 refers the number/index of the custom metric. Note that the data type of ga:metric37 can be INTEGER, CURRENCY or TIME.")]
	public class Metric37: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric37" />.
		/// </summary>
		public Metric37(): base("Custom Metric 37 Value",true,"ga:metric37")
		{
			
		}
	}
}

