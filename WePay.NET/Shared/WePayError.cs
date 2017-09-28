using System;

namespace WePay.Shared
{
    /// <summary>
    /// When an error occurs the API will respond with this
    /// </summary>
    [Serializable]
    public class WePayError : WePayResponse
    {
        /// <summary>
        /// A generic “error” category.
        /// (Enumeration of these values can be found in WePay.Shared.Common.ErrorCategories)
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// A human readable error description that explains why the error happened.
        /// Use this error description to debug the problem.
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// A specific error code that you can use to program responses to errors.
        /// (Enumeration of these values can be found in WePay.Shared.Common.ErrorCodes)
        /// </summary>
        public int? ErrorCode { get; set; }
    }
}