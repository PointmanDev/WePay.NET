using System.Collections.Generic;

namespace WePay.Shared
{
    public class WePayFindResponse<T> : WePayResponse where T : WePayResponse
    {
        public List<T> Results { get; set; }
    }
}