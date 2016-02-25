using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 159 refers the number/index of the custom metric. Note that the data type of ga:metric159 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 159 refers the number/index of the custom metric. Note that the data type of ga:metric159 can be INTEGER, CURRENCY or TIME.")]
	public class Metric159: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric159" />.
		/// </summary>
		public Metric159(): base("Custom Metric 159 Value",true,"ga:metric159")
		{
			
		}
	}
}

