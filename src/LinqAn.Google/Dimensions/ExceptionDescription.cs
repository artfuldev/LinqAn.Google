using System.ComponentModel;

namespace LinqAn.Google.Dimensions
{
	/// <summary>
	/// 	The description for the exception.
	/// </summary>
	[Description("The description for the exception.")]
	public class ExceptionDescription: Dimension
	{
		/// <summary>
		/// 	Instantiates a <seealso cref="ExceptionDescription" />.
		/// </summary>
		public ExceptionDescription(): base("Exception Description",true,"ga:exceptionDescription")
		{
			
		}
	}
}

