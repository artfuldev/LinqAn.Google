namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Typically used to designate a supplying company or brick and mortar location; product affiliation.
	/// </summary>
	public class AffiliationDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AffiliationDimension" />.
		/// </summary>
		public AffiliationDimension(): base("Affiliation","Typically used to designate a supplying company or brick and mortar location; product affiliation.",true,"ga:affiliation")
		{
			
		}
	}
}

