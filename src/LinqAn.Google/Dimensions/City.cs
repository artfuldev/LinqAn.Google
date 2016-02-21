namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The cities of users, derived from IP addresses or Geographical IDs.
	/// </summary>
	public class City: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="City" />.
		/// </summary>
		public City(): base("City","The cities of users, derived from IP addresses or Geographical IDs.",true,"ga:city")
		{
			
		}
	}
}

