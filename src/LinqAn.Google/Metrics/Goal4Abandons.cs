using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal4Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal4Abandons" />.
		/// </summary>
		public Goal4Abandons(): base("Goal 4 Abandoned Funnels",false,"ga:goal4Abandons")
		{
			
		}
	}
}

