using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Report.Common
{
    /// <summary>
    /// All possible report states
    /// </summary>
    public static class ReportStates 
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
        {
            New,
            Processing,
            Complete,
            Deleted,
            Failed
        }

        /// <summary>
        /// Indicates that the Report Create call was successfully executed.
        /// </summary>
        public const string New = "new";

        /// <summary>
        /// The report is being prepared.
        /// </summary>
        public const string Processing = "processing";

        /// <summary>
        /// The report has been successfully prepared and is ready to be retrieved.
        /// </summary>
        public const string Complete = "complete";

        /// <summary>
        /// The report has been deleted and no data from the report can be recovered.
        /// Reports are automatically deleted after four days.
        /// However, you can still retrieve the metadata for the report using the Report Lookup call and passing the ReportId.
        /// </summary>
        public const string Deleted = "deleted";

        /// <summary>
        /// The report did not process and no data can be recovered.
        /// You can still retrieve the metadata for the report using the Report Lookup call and passing the ReportId.
        /// </summary>
        public const string Failed = "failed";

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static ReportStates()
        {
            WePayValues.FillValuesList(typeof(ReportStates), Values);
        }
    }
}