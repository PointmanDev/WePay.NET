using System.Threading.Tasks;
using WePayApi.Shared;
using WePayApi.Report.Request;
using WePayApi.Report.Response;

namespace WePayApi.Report
{
    /// <summary>
    /// Use the the Reports API to request bulk reports for merchants.
    /// Reports are requested and received following these steps:
    /// Your platform requests a report via Report Create.
    /// WePay sends an IPN when the report is available - typically within 5 to 10 minutes.
    /// Your platform uses Report Lookup to obtain the link to download the report.
    /// Your platform can deliver the report(or just the report link) to the merchant in a variety of ways(see the “Receiving Reports” section below).
    /// Use Report Create to request a report. The request includes:
    /// The type of report, The callback URI at which your platform will get an IPN when the report is ready.
    /// ADVANCED OPTIONS: the same options in the wepay.com merchant reports user interface, as appropriate to each type of report(date ranges, for example).
    /// Reports are processed asynchronously, which typically takes 5 to 10 minutes.
    /// Your application will receive a callback when the report is ready.
    /// Lookup will initially show state 'New', which means the request has been received but has not started being processed.
    /// Once processing begins, Report Lookup will show state 'Processing'.
    /// Your application should monitor IPNs and wait for the report to be in state 'Complete'.
    /// When your application receives the IPN, it should call Report Lookup.
    /// Verify that the state is now 'Complete', and then use the report URI to access the data.
    /// The URI will point to a comma-separated values (CSV) file.
    /// Rows are terminated with newlines.
    /// If ReportUriParameter value is null, then the report is still processing.
    /// This should also be reflected in the state parameter.
    /// Reports are available for four days from the time they are generated.
    /// WePay sends an IPN when the report is deleted.
    /// There is delay between the time the data is created or modified and the time it is available for download in a report.
    /// For reconciliation reports, the delay is 6 hours.
    /// For transaction reports, the delay is 36 hours.
    /// Note that this is independent of the 5 to 10 minutes it takes to process a request.
    /// Report generation will automatically fail if the report is requested inside the data latency period.
    /// </summary>
    public class ReportService : WePayApiService<ReportService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Create
        }

        /// <summary>
        /// Use this call to obtain information about a requested report and to obtain the URL from which your report can be downloaded.
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> LookupAsync(LookupRequest lookupRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(lookupRequest, EndPointUrls.Lookup, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to request a report. 
        /// </summary>
        /// <param name="createRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> CreateAsync(CreateRequest createRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(createRequest, EndPointUrls.Lookup,  accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Lookup = "report";
            public const string Create = "report/create";
        }

        public ReportService(bool enableValidation = false,
                             string accessToken = null,
                             bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {

            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}