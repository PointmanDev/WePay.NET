using System.Collections.Generic;
using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// All possible Business Name Types currently supported by WePay
    /// </summary>
    public static class BusinessNameTypes
    {
        /// <summary>
        /// Indices for Values property for iteration
        /// </summary>
        public enum ValuesIndices : int
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

        /// <summary>
        /// Holds all values for iteration
        /// </summary>
        public static readonly List<string> Values = new List<string>();

        static BusinessNameTypes()
        {
            WePayValues.FillValuesList(typeof(BusinessNameTypes), Values);
        }
    }
}