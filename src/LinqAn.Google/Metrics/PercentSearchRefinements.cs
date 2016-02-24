using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of number of times a refinement (i.e., transition) occurs between internal search keywords within a session.
	/// </summary>
	[Description("The percentage of number of times a refinement (i.e., transition) occurs between internal search keywords within a session.")]
	public class PercentSearchRefinements: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PercentSearchRefinements" />.
		/// </summary>
		public PercentSearchRefinements(): base("% Search Refinements",false,"ga:percentSearchRefinements")
		{
			
		}
	}
}

