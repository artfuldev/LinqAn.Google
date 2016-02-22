namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of words in the search query.
	/// </summary>
	public class AdQueryWordCount: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdQueryWordCount" />.
		/// </summary>
		public AdQueryWordCount(): base("Query Word Count","The number of words in the search query.",false,"ga:adQueryWordCount")
		{
			
		}
	}
}

