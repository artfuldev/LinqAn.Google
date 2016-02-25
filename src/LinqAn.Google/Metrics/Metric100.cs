using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 100 refers the number/index of the custom metric. Note that the data type of ga:metric100 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 100 refers the number/index of the custom metric. Note that the data type of ga:metric100 can be INTEGER, CURRENCY or TIME.")]
	public class Metric100: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric100" />.
		/// </summary>
		public Metric100(): base("Custom Metric 100 Value",true,"ga:metric100")
		{
			
		}
	}
}

