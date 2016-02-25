using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 139 refers the number/index of the custom metric. Note that the data type of ga:metric139 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 139 refers the number/index of the custom metric. Note that the data type of ga:metric139 can be INTEGER, CURRENCY or TIME.")]
	public class Metric139: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric139" />.
		/// </summary>
		public Metric139(): base("Custom Metric 139 Value",true,"ga:metric139")
		{
			
		}
	}
}

