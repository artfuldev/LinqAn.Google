using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The value provided when you define custom user segments for your property.
	/// </summary>
	[Description("The value provided when you define custom user segments for your property.")]
	public class UserDefinedValue: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="UserDefinedValue" />.
		/// </summary>
		public UserDefinedValue(): base("User Defined Value",true,"ga:userDefinedValue")
		{
			
		}
	}
}

