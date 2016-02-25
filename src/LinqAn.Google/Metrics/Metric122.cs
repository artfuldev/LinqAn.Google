using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 122 refers the number/index of the custom metric. Note that the data type of ga:metric122 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 122 refers the number/index of the custom metric. Note that the data type of ga:metric122 can be INTEGER, CURRENCY or TIME.")]
	public class Metric122: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric122" />.
		/// </summary>
		public Metric122(): base("Custom Metric 122 Value",true,"ga:metric122")
		{
			
		}
	}
}

