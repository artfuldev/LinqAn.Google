using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal20Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal20Abandons" />.
		/// </summary>
		public Goal20Abandons(): base("Goal 20 Abandoned Funnels",false,"ga:goal20Abandons")
		{
			
		}
	}
}

