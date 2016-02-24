using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	Cost to advertiser per click.
	/// </summary>
	[Description("Cost to advertiser per click.")]
	public class CPC: Metric<decimal>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="CPC" />.
		/// </summary>
		public CPC(): base("CPC",false,"ga:CPC")
		{
			
		}
	}
}

