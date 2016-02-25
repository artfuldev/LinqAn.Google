using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal13Starts: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal13Starts" />.
		/// </summary>
		public Goal13Starts(): base("Goal 13 Starts",true,"ga:goal13Starts")
		{
			
		}
	}
}

