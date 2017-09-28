using WePay.Shared;
using Newtonsoft.Json;
using WePay.Risk.Response;

namespace WePay.Risk.Request
{
    public class FindRequest : WePayRequest<WePayFindResponse<LookupResponse>>
    {
        [JsonIgnore]
        private const string Identifier = "WePay.Risk.Request.FindRequest";

        /// <summary>
        /// The type of object that this rbit is associated with. 
        /// (Enumeration of these values can be found in WePay.Risk.Common.AssociatedObjectTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.AssociatedObjectTypes")]
        public string AssociatedObjectType { get; set; }

        /// <summary>
        /// The unique ID of the object that this rbit is associated with.
        /// </summary>
        public long? AssoicatedObjectId { get; set; }

        /// <summary>
        /// The type of rbit.
        /// (Enumeration of these values can be found in WePay.Risk.Common.RbitTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.RbitTypes")]
        public string Type { get; set; }

        /// <summary>
        /// Source of the information
        /// (Enumeration of these values can be found in WePay.Risk.Common.Sources)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePay.Risk.Common.Sources")]
        public string Source { get; set; }
    }
}
