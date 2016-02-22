using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	A string. Corresponds to AdWords API AdGroup.id.
	/// </summary>
	[Description("A string. Corresponds to AdWords API AdGroup.id.")]
	public class AdwordsAdGroupId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdwordsAdGroupId" />.
		/// </summary>
		public AdwordsAdGroupId(): base("AdWords Ad Group ID",false,"ga:adwordsAdGroupID")
		{
			
		}
	}
}

