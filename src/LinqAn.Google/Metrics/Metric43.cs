using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 43 refers the number/index of the custom metric. Note that the data type of ga:metric43 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 43 refers the number/index of the custom metric. Note that the data type of ga:metric43 can be INTEGER, CURRENCY or TIME.")]
	public class Metric43: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric43" />.
		/// </summary>
		public Metric43(): base("Custom Metric 43 Value",true,"ga:metric43")
		{
			
		}
	}
}

