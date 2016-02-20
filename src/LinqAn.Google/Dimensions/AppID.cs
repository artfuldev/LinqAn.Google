namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The ID of the application.
    /// </summary>
    public class AppID : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="AppID" />.
        /// </summary>
        public AppID() : base("App ID", "The ID of the application.", true, "ga:appId")
        {
        }
    }
}