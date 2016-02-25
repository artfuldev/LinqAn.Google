using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The number of times users started conversion activity on the requested goal number without actually completing it.
	/// </summary>
	[Description("The number of times users started conversion activity on the requested goal number without actually completing it.")]
	public class Goal19Abandons: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal19Abandons" />.
		/// </summary>
		public Goal19Abandons(): base("Goal 19 Abandoned Funnels",false,"ga:goal19Abandons")
		{
			
		}
	}
}

