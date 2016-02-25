using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal8Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal8Abandons" />.
		/// </summary>
		public Goal8Abandons(): base("Goal 8 Abandoned Funnels",false,"ga:goal8Abandons")
		{
			
		}
	}
}

