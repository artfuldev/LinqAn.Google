using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 66 refers the number/index of the custom metric. Note that the data type of ga:metric66 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 66 refers the number/index of the custom metric. Note that the data type of ga:metric66 can be INTEGER, CURRENCY or TIME.")]
	public class Metric66: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric66" />.
		/// </summary>
		public Metric66(): base("Custom Metric 66 Value",true,"ga:metric66")
		{
			
		}
	}
}

