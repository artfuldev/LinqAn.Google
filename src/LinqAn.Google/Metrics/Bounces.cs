using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of single page (or single engagement hit) sessions for your property.
	/// </summary>
	[Description("The total number of single page (or single engagement hit) sessions for your property.")]
	public class Bounces: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Bounces" />.
		/// </summary>
		public Bounces(): base("Bounces",true,"ga:bounces")
		{
			
		}
	}
}

