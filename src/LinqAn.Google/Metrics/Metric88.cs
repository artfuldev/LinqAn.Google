using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 88 refers the number/index of the custom metric. Note that the data type of ga:metric88 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 88 refers the number/index of the custom metric. Note that the data type of ga:metric88 can be INTEGER, CURRENCY or TIME.")]
	public class Metric88: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric88" />.
		/// </summary>
		public Metric88(): base("Custom Metric 88 Value",true,"ga:metric88")
		{
			
		}
	}
}

