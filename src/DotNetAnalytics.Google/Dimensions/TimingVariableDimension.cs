namespace DotNetAnalytics.Google.Dimensions
{
	public class TimingVariableDimension: Dimension<string>
	{
		/// <summary>
		/// 	A value that can be used to add flexibility in visualizing user timings in the reports.
		/// </summary>
		public TimingVariableDimension(): base("Timing Variable","A value that can be used to add flexibility in visualizing user timings in the reports.",true,"ga:userTimingVariable")
		{
			
		}
	}
}

