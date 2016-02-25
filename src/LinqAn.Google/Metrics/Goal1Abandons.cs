using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal1Abandons: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal1Abandons" />.
		/// </summary>
		public Goal1Abandons(): base("Goal 1 Abandoned Funnels",false,"ga:goal1Abandons")
		{
			
		}
	}
}

