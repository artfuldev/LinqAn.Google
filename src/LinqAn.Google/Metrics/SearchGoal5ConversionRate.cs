using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.")]
	public class SearchGoal5ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchGoal5ConversionRate" />.
		/// </summary>
		public SearchGoal5ConversionRate(): base("Site Search Goal 5 Conversion Rate",false,"ga:searchGoal5ConversionRate")
		{
			
		}
	}
}

