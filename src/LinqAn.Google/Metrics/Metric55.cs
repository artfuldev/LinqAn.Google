using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 55 refers the number/index of the custom metric. Note that the data type of ga:metric55 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 55 refers the number/index of the custom metric. Note that the data type of ga:metric55 can be INTEGER, CURRENCY or TIME.")]
	public class Metric55: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric55" />.
		/// </summary>
		public Metric55(): base("Custom Metric 55 Value",true,"ga:metric55")
		{
			
		}
	}
}

