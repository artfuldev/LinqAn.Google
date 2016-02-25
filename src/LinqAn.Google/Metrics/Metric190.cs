using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 190 refers the number/index of the custom metric. Note that the data type of ga:metric190 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 190 refers the number/index of the custom metric. Note that the data type of ga:metric190 can be INTEGER, CURRENCY or TIME.")]
	public class Metric190: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric190" />.
		/// </summary>
		public Metric190(): base("Custom Metric 190 Value",true,"ga:metric190")
		{
			
		}
	}
}

