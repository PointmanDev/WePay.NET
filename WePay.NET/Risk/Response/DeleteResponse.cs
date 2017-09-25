using WePayApi.Shared;

namespace WePayApi.Risk.Response
{
    public class DeleteResponse : WePayResponse
    {
        /// <summary>
        /// The unique ID of the rbit.
        /// </summary>
        public long? RbitId { get; set; }

        /// <summary>
        /// The state of the rbit.
        /// </summary>
        public string State { get; set; }
    }
}