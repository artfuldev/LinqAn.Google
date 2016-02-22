using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The year of the session. A four-digit year from 2005 to the current year.
	/// </summary>
	[Description("The year of the session. A four-digit year from 2005 to the current year.")]
	public class Year: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Year" />.
		/// </summary>
		public Year(): base("Year",false,"ga:year")
		{
			
		}
	}
}

