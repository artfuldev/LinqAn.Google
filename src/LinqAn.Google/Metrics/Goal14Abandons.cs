using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal14Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal14Abandons" />.
		/// </summary>
		public Goal14Abandons(): base("Goal 14 Abandoned Funnels",false,"ga:goal14Abandons")
		{
			
		}
	}
}

