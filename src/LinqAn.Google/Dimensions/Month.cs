namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The month of the session. A two digit integer from 01 to 12.
	/// </summary>
	public class Month: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="Month" />.
		/// </summary>
		public Month(): base("Month of the year","The month of the session. A two digit integer from 01 to 12.",false,"ga:month")
		{
			
		}
	}
}

