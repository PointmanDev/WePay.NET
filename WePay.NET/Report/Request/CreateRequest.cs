using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Report.Response;
using WePay.Report.Structure;
using WePay.Shared;

namespace WePay.Report.Request
{
    public class CreateRequest : WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Report.Request.CreateRequest";

        /// <summary>
        /// The type of report.
        /// (Enumeration of these values can be found in WePay.Report.Common.ReportTypes)
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Report.Common.ReportTypes")]
        public string Type { get; set; }

        /// <summary>
        /// Identifies the object on which the report is based.
        /// </summary>
        [ValidateWePayObject(IsRequired = true, ErrorMessage = Identifier)]
        public ReportResource Resource { get; set; }

        /// <summary>
        /// Advanced options for this report.
        /// </summary>
        [ValidateWePayObject(ErrorMessage = Identifier)]
        public AdvancedOptions AdvancedOptions { get; set; }

        /// <summary>
        /// Where to send IPNs for this report.
        /// </summary>
        [StringLength(2083, ErrorMessage = Identifier + " - CallbackUri cannot exceed 2083 characters")]
        public string CallbackUri { get; set; }
    }
}