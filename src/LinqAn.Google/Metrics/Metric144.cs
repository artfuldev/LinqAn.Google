using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 144 refers the number/index of the custom metric. Note that the data type of ga:metric144 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 144 refers the number/index of the custom metric. Note that the data type of ga:metric144 can be INTEGER, CURRENCY or TIME.")]
	public class Metric144: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric144" />.
		/// </summary>
		public Metric144(): base("Custom Metric 144 Value",true,"ga:metric144")
		{
			
		}
	}
}

