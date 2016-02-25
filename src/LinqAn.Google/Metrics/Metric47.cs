using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 47 refers the number/index of the custom metric. Note that the data type of ga:metric47 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 47 refers the number/index of the custom metric. Note that the data type of ga:metric47 can be INTEGER, CURRENCY or TIME.")]
	public class Metric47: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric47" />.
		/// </summary>
		public Metric47(): base("Custom Metric 47 Value",true,"ga:metric47")
		{
			
		}
	}
}

