using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 109 refers the number/index of the custom metric. Note that the data type of ga:metric109 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 109 refers the number/index of the custom metric. Note that the data type of ga:metric109 can be INTEGER, CURRENCY or TIME.")]
	public class Metric109: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric109" />.
		/// </summary>
		public Metric109(): base("Custom Metric 109 Value",true,"ga:metric109")
		{
			
		}
	}
}

