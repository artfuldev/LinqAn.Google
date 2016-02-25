using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal10Abandons: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal10Abandons" />.
		/// </summary>
		public Goal10Abandons(): base("Goal 10 Abandoned Funnels",false,"ga:goal10Abandons")
		{
			
		}
	}
}

