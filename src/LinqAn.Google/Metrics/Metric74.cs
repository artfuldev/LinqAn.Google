using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 74 refers the number/index of the custom metric. Note that the data type of ga:metric74 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 74 refers the number/index of the custom metric. Note that the data type of ga:metric74 can be INTEGER, CURRENCY or TIME.")]
	public class Metric74: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric74" />.
		/// </summary>
		public Metric74(): base("Custom Metric 74 Value",true,"ga:metric74")
		{
			
		}
	}
}

