using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePayApi.Report.Response;

namespace WePayApi.Report.Request
{
    public class LookupRequest : Shared.WePayRequest<LookupResponse>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Report.Request.LookupRequest";

        /// <summary>
        /// The unique ID of the report for which you want information.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ReportId")]
        public long? ReportId { get; set; }
    }
}