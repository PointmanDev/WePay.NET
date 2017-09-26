using WePayApi.Shared;

namespace WePayApi.Risk.Common
{
    /// <summary>
    /// The source parameter (see Rbit Create API call) can be set to any one of values found here
    /// </summary>
    public class Sources : WePayValues<Sources>
    {
        public enum Indices : int
        {
            User,
            Guidestar,
            ExperianPreciseId,
            ExperianBizId,
            ExperianBizIq,
            Equifax,
            Spokeo,
            Whitepages,
            IrsTinCheck,
            PartnerDatabase,
            PartnerEmployee,
            GenericWebsite
        }

        /// <summary>
        /// Data provided by the user through a webflow
        /// </summary>
        public const string User = "user";

        /// <summary>
        /// www.guidestar.com
        /// </summary>
        public const string Guidestar = "guidestar";

        /// <summary>
        /// www.experian.com
        /// </summary>
        public const string ExperianPreciseId = "experian_precise_id";

        /// <summary>
        /// www.experian.com
        /// </summary>
        public const string ExperianBizId = "experian_biz_id";

        /// <summary>
        /// www.experian.com
        /// </summary>
        public const string ExperianBizIq = "experian_biz_iq";

        /// <summary>
        /// www.equifax.com
        /// </summary>
        public const string Equifax = "equifax";

        /// <summary>
        /// www.spokeo.com
        /// </summary>
        public const string Spokeo = "spokeo";

        /// <summary>
        /// www.whitepages.com
        /// </summary>
        public const string Whitepages = "Whitepages";

        /// <summary>
        /// www.irs.gov
        /// </summary>
        public const string IrsTinCheck = "irs_tin_check";

        /// <summary>
        /// Data gathered directly by partner (for example transaction revenue from partner account).
        /// </summary>
        public const string PartnerDatabase = "partner_database";

        /// <summary>
        /// Data gathered from a partner employee (for example, from a customer service or a sales call).
        /// </summary>
        public const string PartnerEmployee = "partner_employee";

        /// <summary>
        /// Data gathered from a website other than a major data provider.
        /// </summary>
        public const string GenericWebsite = "generic_website";
    }
}