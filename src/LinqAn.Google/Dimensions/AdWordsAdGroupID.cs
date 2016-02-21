namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string. Corresponds to AdWords API AdGroup.id.
	/// </summary>
	public class AdwordsAdGroupId: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdwordsAdGroupId" />.
		/// </summary>
		public AdwordsAdGroupId(): base("AdWords Ad Group ID","A string. Corresponds to AdWords API AdGroup.id.",false,"ga:adwordsAdGroupID")
		{
			
		}
	}
}

