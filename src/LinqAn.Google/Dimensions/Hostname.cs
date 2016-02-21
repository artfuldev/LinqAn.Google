namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The hostname from which the tracking request was made.
	/// </summary>
	public class Hostname: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Hostname" />.
		/// </summary>
		public Hostname(): base("Hostname","The hostname from which the tracking request was made.",true,"ga:hostname")
		{
			
		}
	}
}

