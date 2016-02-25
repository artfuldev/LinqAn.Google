using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 126 refers the number/index of the custom metric. Note that the data type of ga:metric126 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 126 refers the number/index of the custom metric. Note that the data type of ga:metric126 can be INTEGER, CURRENCY or TIME.")]
	public class Metric126: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric126" />.
		/// </summary>
		public Metric126(): base("Custom Metric 126 Value",true,"ga:metric126")
		{
			
		}
	}
}

