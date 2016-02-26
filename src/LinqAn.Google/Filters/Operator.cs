namespace LinqAn.Google.Filters
{
    internal enum Operator
    {
        None,
        Equals,
        DoesNotEqual,
        Contains,
        DoesNotContain,
        MatchesRegex,
        DoesNotMatchRegex,
        LessThan,
        LessThanOrEqualTo,
        GreaterThan,
        GreaterThanOrEqualTo
    }
}