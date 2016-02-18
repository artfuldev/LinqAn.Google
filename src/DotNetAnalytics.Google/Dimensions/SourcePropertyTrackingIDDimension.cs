namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	Source property tracking ID of roll-up properties. This is valid only for roll-up properties.
	/// </summary>
	public class SourcePropertyTrackingIDDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SourcePropertyTrackingIDDimension" />.
		/// </summary>
		public SourcePropertyTrackingIDDimension(): base("Source Property Tracking ID","Source property tracking ID of roll-up properties. This is valid only for roll-up properties.",true,"ga:sourcePropertyTrackingId")
		{
			
		}
	}
}

