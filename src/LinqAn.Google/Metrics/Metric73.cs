using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 73 refers the number/index of the custom metric. Note that the data type of ga:metric73 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 73 refers the number/index of the custom metric. Note that the data type of ga:metric73 can be INTEGER, CURRENCY or TIME.")]
	public class Metric73: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric73" />.
		/// </summary>
		public Metric73(): base("Custom Metric 73 Value",true,"ga:metric73")
		{
			
		}
	}
}

