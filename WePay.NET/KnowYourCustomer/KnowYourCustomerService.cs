using System.Threading.Tasks;
using WePayApi.Shared;
using WePayApi.KnowYourCustomer.Response;
using WePayApi.KnowYourCustomer.Request;
using WePayApi.KnowYourCustomer.Structure;
using WePayApi.Shared.Common;

namespace WePayApi.KnowYourCustomer
{
    public class KnowYourCustomerService : WePayApiService<KnowYourCustomerService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Lookup = 0,
            Create,
            Authorize,
            Modify
        }

        /// <summary>
        /// This call provides information about the status of the account’s KYC information and any documents that may have been uploaded.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="lookupRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> LookupAsync(LookupRequest lookupRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(lookupRequest, EndPointUrls.Lookup, accessToken, useStaging);
        }

        /// <summary>
        /// Use this call to gather the KYC information necessary to complete the merchant onboarding process.
        /// The KnowYourCustomer Create call must be completed before withdrawals can be setup.
        /// Additionally, KnowYourCustomer Create may not be called after withdrawals have been made.
        /// Changes after any withdrawal has been made require intervention by WePay Customer Support and are generally discouraged.
        /// After KYC information is submitted, it may not be modified through an API.
        /// Any necessary changes must be made through WePay Customer Support.
        /// The account for which KYC information is being submitted must be active (the access token for the account must have been confirmed).
        /// The call must be error free.
        /// Any error returned will result in the failure of the entire call.
        /// TIP: Merchant Category Codes (MCC) for the UK (used in the Business, Individual, and Organization Structures) must
        /// a valid UK MCC as defined in the MCC Codes document (https://www.wepay.com/developer/reference/mcc).
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="createRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<CreateResponse> CreateAsync(CreateRequest createRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(createRequest, EndPointUrls.Create, accessToken, useStaging);
        }

        /// <summary>
        /// After KYC information has been entered via the KnowYourCustomer Create call,
        /// the data must be verified as originating from a valid application by means of a server-to-server call. 
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="authorizeRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> AuthorizeAsync(AuthorizeRequest authorizeRequest,
                                                         string accessToken = null,
                                                         bool? useStaging = null)
        {
            return await PostRequestAsync(authorizeRequest, EndPointUrls.Authorize, accessToken, useStaging);
        }

        /// <summary>
        /// This call allows your application to amend an account’s KYC submission with additional data, such as supporting documentation.
        /// PERMISSION REQUIRED
        /// </summary>
        /// <param name="modifyRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<LookupResponse> ModifyAsync(ModifyRequest modifyRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(modifyRequest, EndPointUrls.Modify, accessToken, useStaging);
        }

        private static string BuildAdditionalValidationErrorMessage(string country,
                                                                    string extraField)
        {
            return " Address.Country marked as " + country + " " + extraField + " is the only compliance field that can be non-null.\n";
        }

        public static string GetComplianceAdditonalValidationErrorMessage(string identifier,
                                                                          KycAddress address,
                                                                          bool usCompliant,
                                                                          bool caCompliant,
                                                                          bool gbCompliant,
                                                                          string usComplianceField,
                                                                          string caComplianceField,
                                                                          string gbComplianceField)
        {
            string errorPrefix = "Invalid " + identifier + ", ";
            bool isValid = false;

            if (address != null)
            {
                switch (address.Country)
                {
                    case Countries.US:
                        {
                            isValid = true;

                            if (!usCompliant || (caCompliant || gbCompliant))
                            {
                                return errorPrefix + BuildAdditionalValidationErrorMessage(address.Country, usComplianceField);
                            }

                            break;
                        }
                    case Countries.CA:
                        {
                            isValid = true;

                            if (!caCompliant || (gbCompliant || usCompliant))
                            {
                                return errorPrefix + BuildAdditionalValidationErrorMessage(address.Country, caComplianceField);
                            }

                            break;
                        }
                    case Countries.GB:
                        {
                            isValid = true;

                            if (!gbCompliant || (caCompliant || usCompliant))
                            {
                                return errorPrefix + BuildAdditionalValidationErrorMessage(address.Country, gbComplianceField);
                            }

                            break;
                        }
                }

                return isValid ? null : "could not identify an appropriate Country";
            }

            return errorPrefix + "requires Address to determine correct owner compliance (" + usComplianceField + "," + caComplianceField + " or " + gbComplianceField + ")";
        }

        public static class EndPointUrls
        {
            public const string Lookup = "account/kyc";
            public const string Create = "account/kyc/create";
            public const string Authorize = "account/kyc/authorize";
            public const string Modify = "account/kyc/modify";
        }

        public KnowYourCustomerService(bool enableValidation = false,
                                       string accessToken = null,
                                       bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}