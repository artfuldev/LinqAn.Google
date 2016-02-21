namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York.
	/// </summary>
	public class Region: Dimension<string>
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Region" />.
		/// </summary>
		public Region(): base("Region","The region of users, derived from IP addresses or Geographical IDs. In the U.S., a region is a state, such as New York.",true,"ga:region")
		{
			
		}
	}
}

