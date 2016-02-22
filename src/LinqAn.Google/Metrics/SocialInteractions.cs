using System.ComponentModel;

namespace LinqAn.Google.Metrics
{
	/// <summary>
	/// 	The total number of social interactions.
	/// </summary>
	[Description("The total number of social interactions.")]
	public class SocialInteractions: Metric<int>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SocialInteractions" />.
		/// </summary>
		public SocialInteractions(): base("Social Actions",false,"ga:socialInteractions")
		{
			
		}
	}
}

