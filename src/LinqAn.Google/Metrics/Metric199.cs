using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 199 refers the number/index of the custom metric. Note that the data type of ga:metric199 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 199 refers the number/index of the custom metric. Note that the data type of ga:metric199 can be INTEGER, CURRENCY or TIME.")]
	public class Metric199: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric199" />.
		/// </summary>
		public Metric199(): base("Custom Metric 199 Value",true,"ga:metric199")
		{
			
		}
	}
}

