using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 52 refers the number/index of the custom metric. Note that the data type of ga:metric52 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 52 refers the number/index of the custom metric. Note that the data type of ga:metric52 can be INTEGER, CURRENCY or TIME.")]
	public class Metric52: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric52" />.
		/// </summary>
		public Metric52(): base("Custom Metric 52 Value",true,"ga:metric52")
		{
			
		}
	}
}

