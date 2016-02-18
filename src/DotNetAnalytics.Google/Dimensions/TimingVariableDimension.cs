namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	A value that can be used to add flexibility in visualizing user timings in the reports.
	/// </summary>
	public class TimingVariableDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="TimingVariableDimension" />.
		/// </summary>
		public TimingVariableDimension(): base("Timing Variable","A value that can be used to add flexibility in visualizing user timings in the reports.",true,"ga:userTimingVariable")
		{
			
		}
	}
}

