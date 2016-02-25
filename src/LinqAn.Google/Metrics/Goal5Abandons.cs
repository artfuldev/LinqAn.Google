using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal5Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal5Abandons" />.
		/// </summary>
		public Goal5Abandons(): base("Goal 5 Abandoned Funnels",false,"ga:goal5Abandons")
		{
			
		}
	}
}

