using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 54 refers the number/index of the custom metric. Note that the data type of ga:metric54 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 54 refers the number/index of the custom metric. Note that the data type of ga:metric54 can be INTEGER, CURRENCY or TIME.")]
	public class Metric54: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric54" />.
		/// </summary>
		public Metric54(): base("Custom Metric 54 Value",true,"ga:metric54")
		{
			
		}
	}
}

