using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to at least one of your goals.
	/// </summary>
	[Description("The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to at least one of your goals.")]
	public class SearchGoalConversionRateAll: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchGoalConversionRateAll" />.
		/// </summary>
		public SearchGoalConversionRateAll(): base("Site Search Goal Conversion Rate",false,"ga:searchGoalConversionRateAll")
		{
			
		}
	}
}

