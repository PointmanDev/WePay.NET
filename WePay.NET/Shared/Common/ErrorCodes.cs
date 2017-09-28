namespace WePay.Shared.Common
{
    /// <summary>
    /// All possible Error Codes which WePay can return with an Error response.
    /// </summary>
    public enum ErrorCodes : int
    {
        /// <summary>
        /// You try to make an API call that doesn’t exist like /user/robots.
        /// </summary>
        GenericApiEndPointDoesNotExist = 1001,
        /// <summary>
        /// You are missing a required header such as User-Agent, Content-Type, or Authorization.
        /// </summary>
        GenericMissingRequiredHeader,
        /// <summary>
        /// You passed an invalid parameter value such “robot” for the “fee_payer” parameter.
        /// </summary>
        GenericPassedInvalidParameter,
        /// <summary>
        /// You did not pass a required parameter.
        /// </summary>
        GenericFailedToPassRequiredParameter,
        /// <summary>
        /// We were unable to parse the parameters you passed (ie your JSON is malformed).
        /// </summary>
        GenericMalformedJson,
        /// <summary>
        /// We were completely unable to authenticate your request (probably your access_token doesn’t exist).
        /// </summary>
        GenericUnableToAuthenticate,
        /// <summary>
        /// You have made too many requests in a short time period. See our throttling documentation for more details.
        /// </summary>
        GenericTooManyRequests,
        /// <summary>
        /// WePay encountered an unexpected error. Contact api@wepay.com.
        /// </summary>
        GenericUnexpectedError,
        /// <summary>
        /// This error can be displayed to the user and generally relates to user data - long term this code will be replaced by more specific error codes.
        /// </summary>
        GenericUserDisplayable,
        /// <summary>
        /// You do not have sufficient permissions to perform the requested action.
        /// </summary>
        GenericInsufficientPermissions,
        /// <summary>
        /// The AccessToken you passed has been revoked.
        /// </summary>
        GenericAccessTokenRevoked,
        /// <summary>
        /// The code parameter (OAuth2) has expired.
        /// </summary>
        GenericOAuth2Expired,
        /// <summary>
        /// The ClientId you passed does not match the code parameter.
        /// </summary>
        GenericClientIdDoesNotMatchCodeParameter,
        /// <summary>
        /// IP address you are making API calls from is not on the IP whitelist for your app.
        /// </summary>
        GenericIpAddressNotOnWhitelist,
        /// <summary>
        /// API Version is invalid or expired.
        /// </summary>
        GenericApiVersionInvalidOrExpired,
        /// <summary>
        /// The API version specified in the ‘Api-Version’ header used in the request is not valid for the app.
        /// </summary>
        GenericInvalidApiVersionForApp,
        /// <summary>
        /// The AVS check on the payment failed (invalid billing address).
        /// </summary>
        PaymentAvsCheckOnPaymentFailed = 2001,
        /// <summary>
        /// The card type is not supported (i.e. not Visa, MasterCard, American Express, Discover, JCB, or Diners Club).
        /// </summary>
        PaymentCardTypeUnsupported,
        /// <summary>
        /// The issuing bank indicated that the card is not supported.
        /// </summary>
        PaymentBankIndicatedCardUnsupported,
        /// <summary>
        /// The issuing bank declined the charge but did not tell us why (generally due to a fraud check on their side).
        /// </summary>
        PaymentBankUnspecifiedChargeDeclined,
        /// <summary>
        /// The payment method does not have sufficient funds to make the payment.
        /// </summary>
        PaymentInsufficientFunds,
        /// <summary>
        /// The card has been lost or stolen.
        /// </summary>
        PaymentCardLostOrStolen,
        /// <summary>
        /// The card has expired (some issuing banks don’t care though and we only care if they do).
        /// </summary>
        PaymentCardExpired,
        /// <summary>
        /// Some of the card data was invalid (CVV, expiration date, card number, name on card).
        /// </summary>
        PaymentInvalidCardData,
        /// <summary>
        /// The CreditCard object is in an invalid state for that action.
        /// </summary>
        PaymentInvalidStateForAction,
        /// <summary>
        /// The account you are trying to access does not exist.
        /// </summary>
        AccountDoesNotExist = 3001,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that account.
        /// </summary>
        AccountInsufficientPermissions,
        /// <summary>
        /// The account has been deleted.
        /// </summary>
        AccountDeleted,
        /// <summary>
        /// The account cannot transact.
        /// </summary>
        AccountCannotTransact,
        /// <summary>
        /// The account lacks sufficient funds for the action requested.
        /// </summary>
        AccountInsufficientFunds,
        /// <summary>
        /// The account already provided KYC information.
        /// </summary>
        AccountKycAlreadyProvided,
        /// <summary>
        /// The account must go through KYC before this call can be made.
        /// </summary>
        AccountRequiresKycForCall,
        /// <summary>
        /// The account must complete settlement information before requesting account review.
        /// </summary>
        AccountMustCompleteSettlementInformation,
        /// <summary>
        /// The account must supply a 9-digit social security number when completing KYC.
        /// </summary>
        AccountMustSupplySocialSecurityNumberForKyc,
        /// <summary>
        /// The account KYC state must be in state 'RequireDocs' when calling KnowYourCustomer Modify.
        /// </summary>
        AccountKycMustBeInStateRequireDocs,
        /// <summary>
        /// The account does not own the files specified when calling KnowYourCustomer Modify.
        /// </summary>
        AccountKycFilesNotFound,
        /// <summary>
        /// The account is required to supply the AccountOwner KYC field, however, KYC was attempted to be completed without it.
        /// </summary>
        AccountRequiresAccountOwnerKycField,
        /// <summary>
        /// You must use the financial administrator’s access token.
        /// </summary>
        MembershipMustUseFinancialAdmisitratorAccessToken = 3302,
        /// <summary>
        /// Cannot change financial administrator once withdrawals have started.
        /// </summary>
        MembershipCannotChangeFinancialAdministrator = 3306,
        /// <summary>
        /// The checkout you are trying to view/edit does not exist.
        /// </summary>
        CheckoutDoesNotExist = 4001,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that checkout.
        /// </summary>
        CheckoutInsufficientPermissions,
        /// <summary>
        /// The payment method you passed does not exist or does not belong to the user/app you are authenticated as.
        /// </summary>
        CheckoutPaymentMethodDoesNotExist,
        /// <summary>
        /// The checkout is in an invalid state for that action.
        /// </summary>
        CheckoutInvalidStateForAction,
        /// <summary>
        /// Cannot add signature to this checkout.
        /// </summary>
        CheckoutCannotAddSignature,
        /// <summary>
        /// The preapproval does not exist.
        /// </summary>
        PreapprovalDoesNotExist = 5001,
        /// <summary>
        /// The access_token you have passed belongs to a user that does not have permission to view/modify that checkout.
        /// </summary>
        PreapprovalInsufficientPermissions,
        /// <summary>
        /// If you authenticated with a ClientId/ClientSecret (for app-level preapprovals) then your app cannot access that preapproval.
        /// </summary>
        PreapprovalCannotAccess,
        /// <summary>
        /// You are trying to execute a preapproval where the StartTime has not passed.
        /// </summary>
        PreapprovalStartTimeNotYetPassed,
        /// <summary>
        /// You are trying to execute a preapproval where the EndTime has already passed.
        /// </summary>
        PreapprovalEndTimeAlreadyPassed,
        /// <summary>
        /// The preapproval is in the incorrect state for that action.
        /// </summary>
        PreapprovalInvalidStateForAction,
        /// <summary>
        /// You have tried to authorize the payment method unsuccessfully too many times with this preapproval
        /// </summary>
        PreapprovalTooManyUnsuccessfulAuthorizationAttempts,
        /// <summary>
        /// You are trying to make a payment to an account that this preapproval is not tied to.
        /// </summary>
        PreapprovalAccountPreapprovalMismatch,
        /// <summary>
        /// You have already executed as many checkouts on this period as you are allowed to based on the frequency parameter you set.
        /// </summary>
        PreapprovalCheckoutFrequencyExceeded,
        /// <summary>
        /// You have already reached the amount per period limit you set for this preapproval.
        /// </summary>
        PreapprovalAmountPerPeriodExceeded,
        /// <summary>
        /// You tried to execute two simultaenous payments on a single preapproval.
        /// </summary>
        PreapprovalSimultaneousPaymentExecution,
        /// <summary>
        /// The withdrawal you are trying to access does not exist.
        /// </summary>
        WithdrawalDoesNotExist = 6001,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that withdrawal.
        /// </summary>
        WithdrawalInsufficientPermissions,
        /// <summary>
        /// You are trying to access a user that does not exist or that you do not have permission to access.
        /// </summary>
        UserInsufficientPermissions = 7001,
        /// <summary>
        /// The user is an invalid state for that action.
        /// </summary>
        UserInvalidStateForAction,
        /// <summary>
        /// The user has been deleted.
        /// </summary>
        UserDeleted,
        /// <summary>
        /// The subscription plan you are trying to view/modify does not exist.
        /// </summary>
        SettlementDoesNotExist = 8001,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that subscription plan.
        /// </summary>
        SettlementInsufficientPermissionsToAccessOrModifySubscriptionPlan,
        /// <summary>
        /// The app cannot access the subscription plan.
        /// </summary>
        SettlementAppCannotAccessSubscriptionPlan,
        /// <summary>
        /// The subscription plan has been deleted.
        /// </summary>
        SettlementSubscriptionPlanDeleted,
        /// <summary>
        /// The subscription you are trying to view/modify does not exist
        /// </summary>
        SettlementSubscriptionPlanDoesNotExist,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that subscription.
        /// </summary>
        SettlementInsufficientPermissionsToAccessOrModifySubscription,
        /// <summary>
        /// The app cannot access the subscription.
        /// </summary>
        SettlementAppCannotAccessSubscription,
        /// <summary>
        /// The subscription you are trying to view/modify has expired.
        /// </summary>
        SettlementSubscriptionExpired,
        /// <summary>
        /// The subscription charge you are trying to view/modify does not exist.
        /// </summary>
        SettlementSubscriptionChangeDoesNotExist,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that subscription charge.
        /// </summary>
        SettlementInsufficientPermissionsToAccessOrModifySubscriptionChange,
        /// <summary>
        /// The app cannot access that subscription charge.
        /// </summary>
        SettlementAppCannotAccessSubscriptionCharge
    }
}