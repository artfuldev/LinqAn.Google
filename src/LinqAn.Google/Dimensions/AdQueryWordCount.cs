using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of words in the search query.
	/// </summary>
	[Description("The number of words in the search query.")]
	public class AdQueryWordCount: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdQueryWordCount" />.
		/// </summary>
		public AdQueryWordCount(): base("Query Word Count",false,"ga:adQueryWordCount")
		{
			
		}
	}
}

