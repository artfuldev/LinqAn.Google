using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string. Corresponds to AdWords API Ad.id.
	/// </summary>
	[Description("A string. Corresponds to AdWords API Ad.id.")]
	public class AdwordsCreativeId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdwordsCreativeId" />.
		/// </summary>
		public AdwordsCreativeId(): base("AdWords Creative ID",false,"ga:adwordsCreativeID")
		{
			
		}
	}
}

