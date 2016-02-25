using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 79 refers the number/index of the custom metric. Note that the data type of ga:metric79 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 79 refers the number/index of the custom metric. Note that the data type of ga:metric79 can be INTEGER, CURRENCY or TIME.")]
	public class Metric79: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric79" />.
		/// </summary>
		public Metric79(): base("Custom Metric 79 Value",true,"ga:metric79")
		{
			
		}
	}
}

