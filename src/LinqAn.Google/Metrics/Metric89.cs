using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 89 refers the number/index of the custom metric. Note that the data type of ga:metric89 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 89 refers the number/index of the custom metric. Note that the data type of ga:metric89 can be INTEGER, CURRENCY or TIME.")]
	public class Metric89: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric89" />.
		/// </summary>
		public Metric89(): base("Custom Metric 89 Value",true,"ga:metric89")
		{
			
		}
	}
}

