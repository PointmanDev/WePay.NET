using WePay.Shared;

namespace WePay.Batch.Response
{
    public class BulkCreateResponse : WePayResponse
    {
        public WePayFindResponse<IndividualCreateResponse> Calls { get; set; }
    }
}