using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal7Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal7Abandons" />.
		/// </summary>
		public Goal7Abandons(): base("Goal 7 Abandoned Funnels",false,"ga:goal7Abandons")
		{
			
		}
	}
}

