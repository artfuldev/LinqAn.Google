using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 132 refers the number/index of the custom metric. Note that the data type of ga:metric132 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 132 refers the number/index of the custom metric. Note that the data type of ga:metric132 can be INTEGER, CURRENCY or TIME.")]
	public class Metric132: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric132" />.
		/// </summary>
		public Metric132(): base("Custom Metric 132 Value",true,"ga:metric132")
		{
			
		}
	}
}

