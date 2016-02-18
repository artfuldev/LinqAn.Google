namespace DotNetAnalytics.Google.Dimensions
{
	public class AffiliationDimension: Dimension<string>
	{
		/// <summary>
		/// 	Typically used to designate a supplying company or brick and mortar location; product affiliation.
		/// </summary>
		public AffiliationDimension(): base("Affiliation","Typically used to designate a supplying company or brick and mortar location; product affiliation.",true,"ga:affiliation")
		{
			
		}
	}
}

