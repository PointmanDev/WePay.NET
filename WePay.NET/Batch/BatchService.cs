using System.Collections.Generic;
using System.Threading.Tasks;
using WePay.Batch.Request;
using WePay.Batch.Response;
using WePay.Shared;

namespace WePay.Batch
{
    /// <summary>
    /// Use the following call to make multiple API calls with one HTTP request.
    /// CAUTION: Batch API calls allow your application to avoid throttling limits on sequential API calls.
    /// Your application can send up to 50 API calls within a batch.
    /// However, throttling will still apply to the batch API call itself.
    /// </summary>
    public class BatchService : WePayApiService<BatchService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Create = 0
        }

        /// <summary>
        /// Use the Create call to make multiple API calls within a single API call.
        /// Each call has a ReferenceId that can be used to identify it.
        /// In addition, an AccessToken will be passed for each call in the list, allowing you to make batch API calls for multiple users.
        /// </summary>
        /// <param name="createRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<List<WePayResponse>> CreateAsync(CreateRequest createRequest,
                                                           string accessToken = null,
                                                           bool? useStaging = null)
        {
            var results = new List<WePayResponse>();
            BulkCreateResponse response = await PostRequestAsync(createRequest, EndPointUrls.Create, accessToken, useStaging);

            if (response.Calls != null)
            {
                foreach (var result in response.Calls)
                {
                    results.Add(result.Response);
                }
            }

            return results;
        }

        public static class EndPointUrls
        {
            public const string Create = "batch/create";
        }

        public BatchService(bool enableValidation = false,
                            string accessToken = null,
                            bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}