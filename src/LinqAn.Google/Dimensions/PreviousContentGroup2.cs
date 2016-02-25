using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Refers to content group that was visited before another content group.
	/// </summary>
	[Description("Refers to content group that was visited before another content group.")]
	public class PreviousContentGroup2: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="PreviousContentGroup2" />.
		/// </summary>
		public PreviousContentGroup2(): base("Previous Page Group 2",true,"ga:previousContentGroup2")
		{
			
		}
	}
}

