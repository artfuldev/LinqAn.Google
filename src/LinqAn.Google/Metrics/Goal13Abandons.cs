using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal13Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal13Abandons" />.
		/// </summary>
		public Goal13Abandons(): base("Goal 13 Abandoned Funnels",false,"ga:goal13Abandons")
		{
			
		}
	}
}

