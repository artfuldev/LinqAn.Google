namespace DotNetAnalytics.Google.Dimensions
{
	public class HostnameDimension: Dimension<string>
	{
		/// <summary>
		/// 	The hostname from which the tracking request was made.
		/// </summary>
		public HostnameDimension(): base("Hostname","The hostname from which the tracking request was made.",true,"ga:hostname")
		{
			
		}
	}
}

