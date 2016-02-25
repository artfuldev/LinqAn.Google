using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 48 refers the number/index of the custom metric. Note that the data type of ga:metric48 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 48 refers the number/index of the custom metric. Note that the data type of ga:metric48 can be INTEGER, CURRENCY or TIME.")]
	public class Metric48: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric48" />.
		/// </summary>
		public Metric48(): base("Custom Metric 48 Value",true,"ga:metric48")
		{
			
		}
	}
}

