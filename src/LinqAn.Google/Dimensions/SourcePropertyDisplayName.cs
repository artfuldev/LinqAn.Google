using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	Source property display name of roll-up properties. This is valid only for roll-up properties.
	/// </summary>
	[Description("Source property display name of roll-up properties. This is valid only for roll-up properties.")]
	public class SourcePropertyDisplayName: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="SourcePropertyDisplayName" />.
		/// </summary>
		public SourcePropertyDisplayName(): base("Source Property Display Name",true,"ga:sourcePropertyDisplayName")
		{
			
		}
	}
}

