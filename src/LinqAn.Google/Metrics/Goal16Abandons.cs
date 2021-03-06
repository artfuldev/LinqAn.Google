using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal16Abandons: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal16Abandons" />.
		/// </summary>
		public Goal16Abandons(): base("Goal 16 Abandoned Funnels",false,"ga:goal16Abandons")
		{
			
		}
	}
}

