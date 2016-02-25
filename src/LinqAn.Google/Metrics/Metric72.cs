using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The name of the requested custom metric, where 72 refers the number/index of the custom metric. Note that the data type of ga:metric72 can be INTEGER, CURRENCY or TIME.
	/// </summary>
	[Description("The name of the requested custom metric, where 72 refers the number/index of the custom metric. Note that the data type of ga:metric72 can be INTEGER, CURRENCY or TIME.")]
	public class Metric72: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Metric72" />.
		/// </summary>
		public Metric72(): base("Custom Metric 72 Value",true,"ga:metric72")
		{
			
		}
	}
}

