using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal16Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal16Starts" />.
		/// </summary>
		public Goal16Starts(): base("Goal 16 Starts",true,"ga:goal16Starts")
		{
			
		}
	}
}

