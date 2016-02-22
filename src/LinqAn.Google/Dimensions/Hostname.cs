using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The hostname from which the tracking request was made.
	/// </summary>
	[Description("The hostname from which the tracking request was made.")]
	public class Hostname: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="Hostname" />.
		/// </summary>
		public Hostname(): base("Hostname",true,"ga:hostname")
		{
			
		}
	}
}

