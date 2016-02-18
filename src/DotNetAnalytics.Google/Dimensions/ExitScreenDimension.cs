namespace DotNetAnalytics.Google.Dimensions
{
    /// <summary>
    ///     The name of the screen when the user exited the application.
    /// </summary>
    public class ExitScreenDimension : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ExitScreenDimension" />.
        /// </summary>
        public ExitScreenDimension()
            : base(
                "Exit Screen", "The name of the screen when the user exited the application.", true, "ga:exitScreenName"
                )
        {
        }
    }
}