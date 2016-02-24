using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The percentage of searches that resulted in an immediate exit from your property.
	/// </summary>
	[Description("The percentage of searches that resulted in an immediate exit from your property.")]
	public class SearchExitRate: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SearchExitRate" />.
		/// </summary>
		public SearchExitRate(): base("% Search Exits",false,"ga:searchExitRate")
		{
			
		}
	}
}

