using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 161 refers the number/index of the custom metric. Note that the data type of ga:metric161 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 161 refers the number/index of the custom metric. Note that the data type of ga:metric161 can be INTEGER, CURRENCY or TIME.")]
	public class Metric161: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric161" />.
		/// </summary>
		public Metric161(): base("Custom Metric 161 Value",true,"ga:metric161")
		{
			
		}
	}
}

