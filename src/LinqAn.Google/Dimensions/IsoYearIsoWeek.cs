using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:isoYear and ga:isoWeek.
	/// </summary>
	[Description("Combined values of ga:isoYear and ga:isoWeek.")]
	public class IsoYearIsoWeek: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="IsoYearIsoWeek" />.
		/// </summary>
		public IsoYearIsoWeek(): base("ISO Week of ISO Year",false,"ga:isoYearIsoWeek")
		{
			
		}
	}
}

