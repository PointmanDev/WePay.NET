using System.Collections.Generic;

namespace WePayApi.Shared
{
    public class WePayFindResponse<T> : WePayResponse where T : WePayResponse
    {
        public List<T> Results { get; set; }
    }
}