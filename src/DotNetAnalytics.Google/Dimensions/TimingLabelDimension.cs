namespace DotNetAnalytics.Google.Dimensions
{
	public class TimingLabelDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of the resource's action being tracked.
		/// </summary>
		public TimingLabelDimension(): base("Timing Label","The name of the resource's action being tracked.",true,"ga:userTimingLabel")
		{
			
		}
	}
}

