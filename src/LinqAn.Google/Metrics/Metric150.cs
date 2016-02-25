using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 150 refers the number/index of the custom metric. Note that the data type of ga:metric150 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 150 refers the number/index of the custom metric. Note that the data type of ga:metric150 can be INTEGER, CURRENCY or TIME.")]
	public class Metric150: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric150" />.
		/// </summary>
		public Metric150(): base("Custom Metric 150 Value",true,"ga:metric150")
		{
			
		}
	}
}

