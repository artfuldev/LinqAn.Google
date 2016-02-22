using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The full referring URL including the hostname and path.
	/// </summary>
	[Description("The full referring URL including the hostname and path.")]
	public class FullReferrer: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="FullReferrer" />.
		/// </summary>
		public FullReferrer(): base("Full Referrer",false,"ga:fullReferrer")
		{
			
		}
	}
}

