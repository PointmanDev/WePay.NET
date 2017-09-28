using WePay.Report.Structure;

namespace WePay.Report.Response
{
    public class LookupResponse : Shared.WePayResponse
    {
        /// <summary>
        /// The unique ID of the report.
        /// </summary>
        public long? ReportId { get; set; }

        /// <summary>
        /// The ID of the WePay user for whom the report was requested.
        /// </summary>
        public long? UserId { get; set; }

        /// <summary>
        /// The type of merchant report.
        /// (Enumeration of these values can be found in WePay.Report.Common.ReportTypes)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Describes the object on which this report is based.
        /// </summary>
        public ReportResource Resource { get; set; }

        /// <summary>
        /// Advanced options for this report.
        /// </summary>
        public AdvancedOptions AdvancedOptions { get; set; }

        /// <summary>
        /// The state of the report.
        /// (Enumeration of these values can be found in WePay.Report.Common.ReportStates)
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The Unix timestamp (UTC) when the report was requested
        /// </summary>
        public long? RequestTime { get; set; }

        /// <summary>
        /// The Unix time when the report will expire (UTC).
        /// </summary>
        public long? ExpiresTime { get; set; }

        /// <summary>
        /// Where to send IPNs for this report.
        /// </summary>
        public string CallbackUri { get; set; }

        /// <summary>
        /// The URL from which the report may be downloaded.
        /// The value is null until the report generation is complete.
        /// </summary>
        public string ReportUri { get; set; }
    }
}