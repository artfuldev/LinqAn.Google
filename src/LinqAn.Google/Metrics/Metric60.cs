using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 60 refers the number/index of the custom metric. Note that the data type of ga:metric60 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 60 refers the number/index of the custom metric. Note that the data type of ga:metric60 can be INTEGER, CURRENCY or TIME.")]
	public class Metric60: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric60" />.
		/// </summary>
		public Metric60(): base("Custom Metric 60 Value",true,"ga:metric60")
		{
			
		}
	}
}

