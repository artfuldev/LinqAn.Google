using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The average number of pages people viewed after performing a search.
	/// </summary>
	[Description("The average number of pages people viewed after performing a search.")]
	public class AvgSearchDepth: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AvgSearchDepth" />.
		/// </summary>
		public AvgSearchDepth(): base("Average Search Depth",false,"ga:avgSearchDepth")
		{
			
		}
	}
}

