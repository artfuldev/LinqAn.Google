using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal17Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal17Abandons" />.
		/// </summary>
		public Goal17Abandons(): base("Goal 17 Abandoned Funnels",false,"ga:goal17Abandons")
		{
			
		}
	}
}

