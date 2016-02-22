using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Source property tracking ID of roll-up properties. This is valid only for roll-up properties.
	/// </summary>
	[Description("Source property tracking ID of roll-up properties. This is valid only for roll-up properties.")]
	public class SourcePropertyTrackingId: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SourcePropertyTrackingId" />.
		/// </summary>
		public SourcePropertyTrackingId(): base("Source Property Tracking ID",true,"ga:sourcePropertyTrackingId")
		{
			
		}
	}
}

