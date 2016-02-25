using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of starts for the requested goal number.
	/// </summary>
	[Description("The total number of starts for the requested goal number.")]
	public class Goal8Starts: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Goal8Starts" />.
		/// </summary>
		public Goal8Starts(): base("Goal 8 Starts",true,"ga:goal8Starts")
		{
			
		}
	}
}

