using WePayApi.Shared;
using Newtonsoft.Json;
using WePayApi.Risk.Response;

namespace WePayApi.Risk.Request
{
    public class FindRequest : WePayRequest<WePayFindResponse<LookupResponse>>
    {
        [JsonIgnore]
        private const string Identifier = "WePayApi.Risk.Request.FindRequest";

        /// <summary>
        /// The type of object that this rbit is associated with. 
        /// (Enumeration of these values can be found in WePayApi.Risk.Common.AssociatedObjectTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Risk.Common.AssociatedObjectTypes")]
        public string AssociatedObjectType { get; set; }

        /// <summary>
        /// The unique ID of the object that this rbit is associated with.
        /// </summary>
        public long? AssoicatedObjectId { get; set; }

        /// <summary>
        /// The type of rbit.
        /// (Enumeration of these values can be found in WePayApi.Risk.Common.RbitTypes)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Risk.Common.RbitTypes")]
        public string Type { get; set; }

        /// <summary>
        /// Source of the information
        /// (Enumeration of these values can be found in WePayApi.Risk.Common.Sources)
        /// </summary>
        [ValidateWePayValue(ErrorMessage = Identifier, WePayValuesClassName = "WePayApi.Risk.Common.Sources")]
        public string Source { get; set; }
    }
}
