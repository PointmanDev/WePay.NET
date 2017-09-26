using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Business Name Types currently supported by WePay
    /// </summary>
    public class BusinessNameTypes : WePayValues<BusinessNameTypes>
    {
        public enum Indices : int
        {
            Legal,
            Dba
        }

        /// <summary>
        ///  This is legal name of the company
        /// </summary>
        public const string Legal = "legal";

        /// <summary>
        /// This is the Also Known As or Doing Business As name of the company
        /// </summary>
        public const string Dba = "dba";
    }
}