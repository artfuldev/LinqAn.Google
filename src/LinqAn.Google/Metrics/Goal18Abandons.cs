using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal18Abandons: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal18Abandons" />.
		/// </summary>
		public Goal18Abandons(): base("Goal 18 Abandoned Funnels",false,"ga:goal18Abandons")
		{
			
		}
	}
}

