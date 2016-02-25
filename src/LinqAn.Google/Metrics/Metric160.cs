using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 160 refers the number/index of the custom metric. Note that the data type of ga:metric160 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 160 refers the number/index of the custom metric. Note that the data type of ga:metric160 can be INTEGER, CURRENCY or TIME.")]
	public class Metric160: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric160" />.
		/// </summary>
		public Metric160(): base("Custom Metric 160 Value",true,"ga:metric160")
		{
			
		}
	}
}

