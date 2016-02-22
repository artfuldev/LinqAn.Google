using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The number of days elapsed since users last visited your property. Used to calculate user loyalty.
	/// </summary>
	[Description("The number of days elapsed since users last visited your property. Used to calculate user loyalty.")]
	public class DaysSinceLastSession: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="DaysSinceLastSession" />.
		/// </summary>
		public DaysSinceLastSession(): base("Days Since Last Session",true,"ga:daysSinceLastSession")
		{
			
		}
	}
}

