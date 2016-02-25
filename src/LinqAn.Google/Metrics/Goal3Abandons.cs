using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal3Abandons: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal3Abandons" />.
		/// </summary>
		public Goal3Abandons(): base("Goal 3 Abandoned Funnels",false,"ga:goal3Abandons")
		{
			
		}
	}
}

