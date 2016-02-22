using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of your AdWords ad group.
	/// </summary>
	[Description("The name of your AdWords ad group.")]
	public class AdGroup: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="AdGroup" />.
		/// </summary>
		public AdGroup(): base("Ad Group",true,"ga:adGroup")
		{
			
		}
	}
}

