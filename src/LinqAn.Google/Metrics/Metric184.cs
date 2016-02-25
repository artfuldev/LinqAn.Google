using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 184 refers the number/index of the custom metric. Note that the data type of ga:metric184 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 184 refers the number/index of the custom metric. Note that the data type of ga:metric184 can be INTEGER, CURRENCY or TIME.")]
	public class Metric184: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric184" />.
		/// </summary>
		public Metric184(): base("Custom Metric 184 Value",true,"ga:metric184")
		{
			
		}
	}
}

