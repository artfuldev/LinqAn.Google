using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 86 refers the number/index of the custom metric. Note that the data type of ga:metric86 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 86 refers the number/index of the custom metric. Note that the data type of ga:metric86 can be INTEGER, CURRENCY or TIME.")]
	public class Metric86: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric86" />.
		/// </summary>
		public Metric86(): base("Custom Metric 86 Value",true,"ga:metric86")
		{
			
		}
	}
}

