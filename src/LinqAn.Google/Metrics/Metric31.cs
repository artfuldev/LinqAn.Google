using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 31 refers the number/index of the custom metric. Note that the data type of ga:metric31 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 31 refers the number/index of the custom metric. Note that the data type of ga:metric31 can be INTEGER, CURRENCY or TIME.")]
	public class Metric31: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric31" />.
		/// </summary>
		public Metric31(): base("Custom Metric 31 Value",true,"ga:metric31")
		{
			
		}
	}
}

