using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 146 refers the number/index of the custom metric. Note that the data type of ga:metric146 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 146 refers the number/index of the custom metric. Note that the data type of ga:metric146 can be INTEGER, CURRENCY or TIME.")]
	public class Metric146: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric146" />.
		/// </summary>
		public Metric146(): base("Custom Metric 146 Value",true,"ga:metric146")
		{
			
		}
	}
}

