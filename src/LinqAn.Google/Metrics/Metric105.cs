using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 105 refers the number/index of the custom metric. Note that the data type of ga:metric105 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 105 refers the number/index of the custom metric. Note that the data type of ga:metric105 can be INTEGER, CURRENCY or TIME.")]
	public class Metric105: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric105" />.
		/// </summary>
		public Metric105(): base("Custom Metric 105 Value",true,"ga:metric105")
		{
			
		}
	}
}

