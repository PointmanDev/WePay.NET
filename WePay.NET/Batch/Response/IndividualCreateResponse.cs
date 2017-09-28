using WePay.Shared;

namespace WePay.Batch.Response
{
    public class IndividualCreateResponse : WePayResponse
    {
        public string Call { get; set; }

        public string ReferenceId { get; set; }

        public WePayResponse Response { get; set; }
    }
}