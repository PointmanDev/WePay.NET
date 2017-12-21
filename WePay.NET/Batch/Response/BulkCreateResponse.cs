using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using WePay.Shared;

namespace WePay.Batch.Response
{
    public class BulkCreateResponse : WePayResponse
    {
        public List<JObject> Calls { get; set; }
    }
}