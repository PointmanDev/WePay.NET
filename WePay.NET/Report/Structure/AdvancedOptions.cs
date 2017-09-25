namespace WePayApi.Report.Structure
{
    /// <summary>
    /// Contains the Unix timestamps (UTC) for the date range of the report.
    /// </summary>
    public class AdvancedOptions
    {
        /// <summary>
        /// The start of the time range (UTC Unix timestamp) selected for the report data.
        /// </summary>
        public long? StartTime { get; set; }

        /// <summary>
        /// The end of the time range (UTC Unix timestamp) selected for the report data.
        /// </summary>
        public long? EndTime { get; set; }

        /// <summary>
        /// Flag to control whether or not an email is sent out when the generation of the report is complete
        /// Default: true
        /// Note: This field is only returned in the Report Lookup Response.
        /// It is not a parameter that you can currently set in Report Create
        /// </summary>
        public bool? DisableEmail { get; set; }
    }
}