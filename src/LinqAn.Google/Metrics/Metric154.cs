using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 154 refers the number/index of the custom metric. Note that the data type of ga:metric154 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 154 refers the number/index of the custom metric. Note that the data type of ga:metric154 can be INTEGER, CURRENCY or TIME.")]
	public class Metric154: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric154" />.
		/// </summary>
		public Metric154(): base("Custom Metric 154 Value",true,"ga:metric154")
		{
			
		}
	}
}

