namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	A string. Corresponds to AdWords API Ad.id.
	/// </summary>
	public class AdWordsCreativeIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="AdWordsCreativeIDDimension" />.
		/// </summary>
		public AdWordsCreativeIDDimension(): base("AdWords Creative ID","A string. Corresponds to AdWords API Ad.id.",false,"ga:adwordsCreativeID")
		{
			
		}
	}
}

