using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Report.Response;

namespace WePay.Report.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Report.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the report for which you want information.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ReportId")]
        public long? ReportId { get; set; }
    }
}