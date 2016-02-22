namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The year of the session. A four-digit year from 2005 to the current year.
	/// </summary>
	public class Year: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Year" />.
		/// </summary>
		public Year(): base("Year","The year of the session. A four-digit year from 2005 to the current year.",false,"ga:year")
		{
			
		}
	}
}

