using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Returns the minute in the hour. The possible values are between 00 and 59.
	/// </summary>
	[Description("Returns the minute in the hour. The possible values are between 00 and 59.")]
	public class Minute: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Minute" />.
		/// </summary>
		public Minute(): base("Minute",true,"ga:minute")
		{
			
		}
	}
}

