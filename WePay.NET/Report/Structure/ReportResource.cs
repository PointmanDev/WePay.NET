using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WePay.Shared;

namespace WePay.Report.Structure
{
    /// <summary>
    /// Contains information about the resources about which the report is based.
    /// </summary>
    public class ReportResource
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Report.Structure.ReportResource";

        /// <summary>
        /// The type of resource upon which the report is based.
        /// (Enumeration of these values can be found in WePay.Report.Common.ObjectTypes)
        /// Note: Use Account for MerchantTransactions reports and Withdrawal for Reconciliation reports.
        /// </summary>
        [ValidateWePayValue(IsRequired = true, ErrorMessage = Identifier, WePayValuesClassName = "WePay.Report.Common.ObjectTypes")]
        public string ObjectType { get; set; }

        /// <summary>
        /// The unique ID of the resource upon which this report is based.
        /// The resources referred to by this ID are the AccountId or the WithdrawalId for the object specified in ObjectType above.
        /// </summary>
        [Required(ErrorMessage = Identifier + " - Requires ObjectId")]
        public long? ObjectId { get; set; }
    }
}