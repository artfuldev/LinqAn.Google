using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 180 refers the number/index of the custom metric. Note that the data type of ga:metric180 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 180 refers the number/index of the custom metric. Note that the data type of ga:metric180 can be INTEGER, CURRENCY or TIME.")]
	public class Metric180: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric180" />.
		/// </summary>
		public Metric180(): base("Custom Metric 180 Value",true,"ga:metric180")
		{
			
		}
	}
}

