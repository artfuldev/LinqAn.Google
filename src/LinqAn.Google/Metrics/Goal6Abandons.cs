using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal6Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal6Abandons" />.
		/// </summary>
		public Goal6Abandons(): base("Goal 6 Abandoned Funnels",false,"ga:goal6Abandons")
		{
			
		}
	}
}

