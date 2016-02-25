using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.
	/// </summary>
	[Description("The percentage of search sessions (i.e., sessions that included at least one search) which resulted in a conversion to the requested goal number.")]
	public class SearchGoal19ConversionRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchGoal19ConversionRate" />.
		/// </summary>
		public SearchGoal19ConversionRate(): base("Site Search Goal 19 Conversion Rate",false,"ga:searchGoal19ConversionRate")
		{
			
		}
	}
}

