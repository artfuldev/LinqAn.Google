using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Return On Ad Spend (ROAS) is the total transaction revenue and goal value divided by derived advertising cost.
	/// </summary>
	[Description("Return On Ad Spend (ROAS) is the total transaction revenue and goal value divided by derived advertising cost.")]
	public class ROAS: Metric<float>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ROAS" />.
		/// </summary>
		public ROAS(): base("ROAS",false,"ga:ROAS")
		{
			
		}
	}
}

