using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal15Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal15Abandons" />.
		/// </summary>
		public Goal15Abandons(): base("Goal 15 Abandoned Funnels",false,"ga:goal15Abandons")
		{
			
		}
	}
}

