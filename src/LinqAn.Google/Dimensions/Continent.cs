namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The continents of users, derived from IP addresses or Geographical IDs.
	/// </summary>
	public class Continent: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Continent" />.
		/// </summary>
		public Continent(): base("Continent","The continents of users, derived from IP addresses or Geographical IDs.",true,"ga:continent")
		{
			
		}
	}
}

