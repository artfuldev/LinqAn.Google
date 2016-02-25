using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 173 refers the number/index of the custom metric. Note that the data type of ga:metric173 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 173 refers the number/index of the custom metric. Note that the data type of ga:metric173 can be INTEGER, CURRENCY or TIME.")]
	public class Metric173: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric173" />.
		/// </summary>
		public Metric173(): base("Custom Metric 173 Value",true,"ga:metric173")
		{
			
		}
	}
}

