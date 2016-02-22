using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The name of the resource's action being tracked.
	/// </summary>
	[Description("The name of the resource's action being tracked.")]
	public class UserTimingLabel: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserTimingLabel" />.
		/// </summary>
		public UserTimingLabel(): base("Timing Label",true,"ga:userTimingLabel")
		{
			
		}
	}
}

