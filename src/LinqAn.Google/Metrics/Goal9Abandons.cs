using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal9Abandons: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal9Abandons" />.
		/// </summary>
		public Goal9Abandons(): base("Goal 9 Abandoned Funnels",false,"ga:goal9Abandons")
		{
			
		}
	}
}

