using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 83 refers the number/index of the custom metric. Note that the data type of ga:metric83 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 83 refers the number/index of the custom metric. Note that the data type of ga:metric83 can be INTEGER, CURRENCY or TIME.")]
	public class Metric83: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric83" />.
		/// </summary>
		public Metric83(): base("Custom Metric 83 Value",true,"ga:metric83")
		{
			
		}
	}
}

