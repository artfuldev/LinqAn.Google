using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal12Abandons: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal12Abandons" />.
		/// </summary>
		public Goal12Abandons(): base("Goal 12 Abandoned Funnels",false,"ga:goal12Abandons")
		{
			
		}
	}
}

