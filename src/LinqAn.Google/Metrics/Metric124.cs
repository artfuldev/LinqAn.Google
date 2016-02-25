using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 124 refers the number/index of the custom metric. Note that the data type of ga:metric124 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 124 refers the number/index of the custom metric. Note that the data type of ga:metric124 can be INTEGER, CURRENCY or TIME.")]
	public class Metric124: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric124" />.
		/// </summary>
		public Metric124(): base("Custom Metric 124 Value",true,"ga:metric124")
		{
			
		}
	}
}

