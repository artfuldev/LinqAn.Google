using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal12Starts: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal12Starts" />.
		/// </summary>
		public Goal12Starts(): base("Goal 12 Starts",true,"ga:goal12Starts")
		{
			
		}
	}
}

