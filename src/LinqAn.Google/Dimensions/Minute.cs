namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Returns the minute in the hour. The possible values are between 00 and 59.
	/// </summary>
	public class Minute: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Minute" />.
		/// </summary>
		public Minute(): base("Minute","Returns the minute in the hour. The possible values are between 00 and 59.",true,"ga:minute")
		{
			
		}
	}
}

