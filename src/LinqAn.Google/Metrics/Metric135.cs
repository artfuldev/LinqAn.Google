using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 135 refers the number/index of the custom metric. Note that the data type of ga:metric135 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 135 refers the number/index of the custom metric. Note that the data type of ga:metric135 can be INTEGER, CURRENCY or TIME.")]
	public class Metric135: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric135" />.
		/// </summary>
		public Metric135(): base("Custom Metric 135 Value",true,"ga:metric135")
		{
			
		}
	}
}

