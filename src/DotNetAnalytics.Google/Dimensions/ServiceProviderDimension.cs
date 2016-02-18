namespace DotNetAnalytics.Google.Dimensions
{
	public class ServiceProviderDimension: Dimension<string>
	{
		/// <summary>
		/// 	The name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element.
		/// </summary>
		public ServiceProviderDimension(): base("Service Provider","The name of service providers used to reach your property. For example, if most users to your website come via the major service providers for cable internet, you will see the names of those cable service providers in this element.",true,"ga:networkLocation")
		{
			
		}
	}
}

