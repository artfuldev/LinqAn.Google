using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 77 refers the number/index of the custom metric. Note that the data type of ga:metric77 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 77 refers the number/index of the custom metric. Note that the data type of ga:metric77 can be INTEGER, CURRENCY or TIME.")]
	public class Metric77: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric77" />.
		/// </summary>
		public Metric77(): base("Custom Metric 77 Value",true,"ga:metric77")
		{
			
		}
	}
}

