namespace LinqAn.Google.Dimensions
{
    /// <summary>
    ///     The name of the screen when the user exited the application.
    /// </summary>
    public class ExitScreen : Dimension<string>
    {
        /// <summary>
        ///     Instantiates a <seealso cref="ExitScreen" />.
        /// </summary>
        public ExitScreen()
            : base(
                "Exit Screen", "The name of the screen when the user exited the application.", true, "ga:exitScreenName"
                )
        {
        }
    }
}