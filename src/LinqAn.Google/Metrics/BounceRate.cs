using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of single-page session (i.e., session in which the person left your property from the first page).
	/// </summary>
	[Description("The percentage of single-page session (i.e., session in which the person left your property from the first page).")]
	public class BounceRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="BounceRate" />.
		/// </summary>
		public BounceRate(): base("Bounce Rate",false,"ga:bounceRate")
		{
			
		}
	}
}

