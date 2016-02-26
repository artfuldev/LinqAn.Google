using System;
using Google.Apis.Analytics.v3.Data;

namespace LinqAn.Google.Linq.Provision
{
    internal interface IReportingClient : IDisposable
    {
        GaData GetAllGaData(IRecordQuery query);
        GaData GetAllGaData(IRecordQuery query, uint startIndex, out int? totalRecords);
        GaData GetGaData(IRecordQuery query, out int? totalRecords, uint startIndex = 1,
            uint maxRecordsCount = RecordQuery.MaxRecordsPerQuery);
    }
}