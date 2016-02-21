namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe.
	/// </summary>
	public class SubContinent: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="SubContinent" />.
		/// </summary>
		public SubContinent(): base("Sub Continent","The sub-continent of users, derived from IP addresses or Geographical IDs. For example, Polynesia or Northern Europe.",true,"ga:subContinent")
		{
			
		}
	}
}

