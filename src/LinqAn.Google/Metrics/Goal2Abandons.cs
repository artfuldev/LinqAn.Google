using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal2Abandons: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal2Abandons" />.
		/// </summary>
		public Goal2Abandons(): base("Goal 2 Abandoned Funnels",false,"ga:goal2Abandons")
		{
			
		}
	}
}

