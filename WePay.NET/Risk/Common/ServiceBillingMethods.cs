using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Service Period Billing Methods currently supported by WePay
    /// </summary>
    public class ServiceBillingMethods : WePayValues<ServiceBillingMethods>
    {
        public enum Indices : int
        {
            FreeFormEntry,
            TimedBillingAtStaffRate,
            TimedBillingAtTaskRate,
            TimedBillingAtProjectRate,
            HourlyBillingAtStaffRate,
            HourlyBillingAtTaskRate,
            HourlyBillingAtProjectRate,
            FlatProjectAmount
        }

        /// <summary>
        /// User entered or edited line item directly on invoice.
        /// </summary>
        public const string FreeFormEntry = "free_form_entry";

        /// <summary>
        /// Rate set per staff member and hours timed automatically.
        /// </summary>
        public const string TimedBillingAtStaffRate = "timed_billing_at_staff_rate";

        /// <summary>
        /// Rate set per task and hours timed automatically.
        /// </summary>
        public const string TimedBillingAtTaskRate = "timed_billing_at_task_rate";

        /// <summary>
        /// Rate set per project and hours timed automatically.
        /// </summary>
        public const string TimedBillingAtProjectRate = "timed_billing_at_project_rate";

        /// <summary>
        /// Rate set per staff member and hours entered manually.
        /// </summary>
        public const string HourlyBillingAtStaffRate = "hourly_billing_at_staff_rate";

        /// <summary>
        /// Rate set per task and hours entered manually.
        /// </summary>
        public const string HourlyBillingAtTaskRate = "hourly_billing_at_task_rate";

        /// <summary>
        /// Rate set per project and hours entered manually.
        /// </summary>
        public const string HourlyBillingAtProjectRate = "hourly_billing_at_project_rate";

        /// <summary>
        /// Flat invoicing per project.
        /// </summary>
        public const string FlatProjectAmount = "flat_project_amount";
    }
}