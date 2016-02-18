namespace DotNetAnalytics.Google.Dimensions
{
	/// <summary>
	/// 	The name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element.
	/// </summary>
	public class ServiceProviderDimension: Dimension<string>
	{
		/// <summary>
	/// 	Instantiates a <seealso cref="ServiceProviderDimension" />.
		/// </summary>
		public ServiceProviderDimension(): base("Service Provider","The name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element.",true,"ga:networkLocation")
		{
			
		}
	}
}

