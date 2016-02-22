using System;
using Google.Apis.Analytics.v3;
using LinqAn.Google.Linq.Clients;
using LinqAn.Google.Linq.Queryables;

namespace LinqAn.Google
{
    public interface IAnalyticsContext
    {
        RecordsDataSet Records { get; }
    }
}