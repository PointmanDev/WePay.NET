using WePayApi.Shared;

namespace WePayApi.Batch.Response
{
    public class BulkCreateResponse : WePayResponse
    {
        public WePayFindResponse<IndividualCreateResponse> Calls { get; set; }
    }
}