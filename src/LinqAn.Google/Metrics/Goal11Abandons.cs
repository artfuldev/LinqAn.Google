using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal11Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal11Abandons" />.
		/// </summary>
		public Goal11Abandons(): base("Goal 11 Abandoned Funnels",false,"ga:goal11Abandons")
		{
			
		}
	}
}

