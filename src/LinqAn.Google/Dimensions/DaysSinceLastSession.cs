namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of days elapsed since users last visited your property. Used to calculate user loyalty.
	/// </summary>
	public class DaysSinceLastSession: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DaysSinceLastSession" />.
		/// </summary>
		public DaysSinceLastSession(): base("Days Since Last Session","The number of days elapsed since users last visited your property. Used to calculate user loyalty.",true,"ga:daysSinceLastSession")
		{
			
		}
	}
}

