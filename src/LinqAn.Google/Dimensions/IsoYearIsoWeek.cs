namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Combined values of ga:isoYear and ga:isoWeek.
	/// </summary>
	public class IsoYearIsoWeek: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="IsoYearIsoWeek" />.
		/// </summary>
		public IsoYearIsoWeek(): base("ISO Week of ISO Year","Combined values of ga:isoYear and ga:isoWeek.",false,"ga:isoYearIsoWeek")
		{
			
		}
	}
}

