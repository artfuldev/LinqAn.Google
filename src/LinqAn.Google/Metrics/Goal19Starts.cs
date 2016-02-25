using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal19Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal19Starts" />.
		/// </summary>
		public Goal19Starts(): base("Goal 19 Starts",true,"ga:goal19Starts")
		{
			
		}
	}
}

