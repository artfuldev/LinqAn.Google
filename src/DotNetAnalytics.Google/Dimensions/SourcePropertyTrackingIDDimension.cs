namespace DotNetAnalytics.Google.Dimensions
{
	public class SourcePropertyTrackingIDDimension: Dimension<string>
	{
		/// <summary>
		/// 	Source property tracking ID of roll-up properties. This is valid only for roll-up properties.
		/// </summary>
		public SourcePropertyTrackingIDDimension(): base("Source Property Tracking ID","Source property tracking ID of roll-up properties. This is valid only for roll-up properties.",true,"ga:sourcePropertyTrackingId")
		{
			
		}
	}
}

