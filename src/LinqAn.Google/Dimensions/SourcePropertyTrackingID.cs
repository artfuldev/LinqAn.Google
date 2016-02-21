namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Source property tracking ID of roll-up properties. This is valid only for roll-up properties.
	/// </summary>
	public class SourcePropertyTrackingId: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SourcePropertyTrackingId" />.
		/// </summary>
		public SourcePropertyTrackingId(): base("Source Property Tracking ID","Source property tracking ID of roll-up properties. This is valid only for roll-up properties.",true,"ga:sourcePropertyTrackingId")
		{
			
		}
	}
}

