namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible Error Codes which WePay can return with an Error response.
    /// </summary>
    public enum Choices : int
    {
        /// <summary>
        /// You try to make an API call that doesn’t exist like /user/robots.
        /// </summary>
        Generic_ApiEndPointDoesNotExist = 1001,
        /// <summary>
        /// You are missing a required header such as User-Agent, Content-Type, or Authorization.
        /// </summary>
        Generic_MissingRequiredHeader,
        /// <summary>
        /// You passed an invalid parameter value such “robot” for the “fee_payer” parameter.
        /// </summary>
        Generic_PassedInvalidParameter,
        /// <summary>
        /// You did not pass a required parameter.
        /// </summary>
        Generic_FailedToPassRequiredParameter,
        /// <summary>
        /// We were unable to parse the parameters you passed (ie your JSON is malformed).
        /// </summary>
        Generic_MalformedJson,
        /// <summary>
        /// We were completely unable to authenticate your request (probably your access_token doesn’t exist).
        /// </summary>
        Generic_UnableToAuthenticate,
        /// <summary>
        /// You have made too many requests in a short time period. See our throttling documentation for more details.
        /// </summary>
        Generic_TooManyRequests,
        /// <summary>
        /// WePay encountered an unexpected error. Contact api@wepay.com.
        /// </summary>
        Generic_UnexpectedError,
        /// <summary>
        /// This error can be displayed to the user and generally relates to user data - long term this code will be replaced by more specific error codes.
        /// </summary>
        Generic_UserDisplayable,
        /// <summary>
        /// You do not have sufficient permissions to perform the requested action.
        /// </summary>
        Generic_InsufficientPermissions,
        /// <summary>
        /// The AccessToken you passed has been revoked.
        /// </summary>
        Generic_AccessTokenRevoked,
        /// <summary>
        /// The code parameter (OAuth2) has expired.
        /// </summary>
        Generic_OAuth2Expired,
        /// <summary>
        /// The ClientId you passed does not match the code parameter.
        /// </summary>
        Generic_ClientIdDoesNotMatchCodeParameter,
        /// <summary>
        /// IP address you are making API calls from is not on the IP whitelist for your app.
        /// </summary>
        Generic_IpAddressNotOnWhitelist,
        /// <summary>
        /// API Version is invalid or expired.
        /// </summary>
        Generic_ApiVersionInvalidOrExpired,
        /// <summary>
        /// The API version specified in the ‘Api-Version’ header used in the request is not valid for the app.
        /// </summary>
        Generic_InvalidApiVersionForApp,
        /// <summary>
        /// The AVS check on the payment failed (invalid billing address).
        /// </summary>
        Payment_AvsCheckOnPaymentFailed = 2001,
        /// <summary>
        /// The card type is not supported (i.e. not Visa, MasterCard, American Express, Discover, JCB, or Diners Club).
        /// </summary>
        Payment_CardTypeUnsupported,
        /// <summary>
        /// The issuing bank indicated that the card is not supported.
        /// </summary>
        Payment_BankIndicatedCardUnsupported,
        /// <summary>
        /// The issuing bank declined the charge but did not tell us why (generally due to a fraud check on their side).
        /// </summary>
        Payment_BankUnspecifiedChargeDeclined,
        /// <summary>
        /// The payment method does not have sufficient funds to make the payment.
        /// </summary>
        Payment_InsufficientFunds,
        /// <summary>
        /// The card has been lost or stolen.
        /// </summary>
        Payment_CardLostOrStolen,
        /// <summary>
        /// The card has expired (some issuing banks don’t care though and we only care if they do).
        /// </summary>
        Payment_CardExpired,
        /// <summary>
        /// Some of the card data was invalid (CVV, expiration date, card number, name on card).
        /// </summary>
        Payment_InvalidCardData,
        /// <summary>
        /// The CreditCard object is in an invalid state for that action.
        /// </summary>
        Payment_InvalidStateForAction,
        /// <summary>
        /// The account you are trying to access does not exist.
        /// </summary>
        Account_DoesNotExist = 3001,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that account.
        /// </summary>
        Account_InsufficientPermissions,
        /// <summary>
        /// The account has been deleted.
        /// </summary>
        Account_Deleted,
        /// <summary>
        /// The account cannot transact.
        /// </summary>
        Account_CannotTransact,
        /// <summary>
        /// The account lacks sufficient funds for the action requested.
        /// </summary>
        Account_InsufficientFunds,
        /// <summary>
        /// The account already provided KYC information.
        /// </summary>
        Account_KycAlreadyProvided,
        /// <summary>
        /// The account must go through KYC before this call can be made.
        /// </summary>
        Account_RequiresKycForCall,
        /// <summary>
        /// The account must complete settlement information before requesting account review.
        /// </summary>
        Account_MustCompleteSettlementInformation,
        /// <summary>
        /// The account must supply a 9-digit social security number when completing KYC.
        /// </summary>
        Account_MustSupplySocialSecurityNumberForKyc,
        /// <summary>
        /// The account KYC state must be in state 'RequireDocs' when calling KnowYourCustomer Modify.
        /// </summary>
        Account_KycMustBeInStateRequireDocs,
        /// <summary>
        /// The account does not own the files specified when calling KnowYourCustomer Modify.
        /// </summary>
        Account_KycFilesNotFound,
        /// <summary>
        /// The account is required to supply the AccountOwner KYC field, however, KYC was attempted to be completed without it.
        /// </summary>
        Account_RequiresAccountOwnerKycField,
        /// <summary>
        /// You must use the financial administrator’s access token.
        /// </summary>
        Membership_MustUseFinancialAdmisitratorAccessToken = 3302,
        /// <summary>
        /// Cannot change financial administrator once withdrawals have started.
        /// </summary>
        Membership_CannotChangeFinancialAdministrator = 3306,
        /// <summary>
        /// The checkout you are trying to view/edit does not exist.
        /// </summary>
        Checkout_DoesNotExist = 4001,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that checkout.
        /// </summary>
        Checkout_InsufficientPermissions,
        /// <summary>
        /// The payment method you passed does not exist or does not belong to the user/app you are authenticated as.
        /// </summary>
        Checkout_PaymentMethodDoesNotExist,
        /// <summary>
        /// The checkout is in an invalid state for that action.
        /// </summary>
        Checkout_InvalidStateForAction,
        /// <summary>
        /// Cannot add signature to this checkout.
        /// </summary>
        Checkout_CannotAddSignature,
        /// <summary>
        /// The preapproval does not exist.
        /// </summary>
        Preapproval_DoesNotExist = 5001,
        /// <summary>
        /// The access_token you have passed belongs to a user that does not have permission to view/modify that checkout.
        /// </summary>
        Preapproval_InsufficientPermissions,
        /// <summary>
        /// If you authenticated with a ClientId/ClientSecret (for app-level preapprovals) then your app cannot access that preapproval.
        /// </summary>
        Preapproval_CannotAccess,
        /// <summary>
        /// You are trying to execute a preapproval where the StartTime has not passed.
        /// </summary>
        Preapproval_StartTimeNotYetPassed,
        /// <summary>
        /// You are trying to execute a preapproval where the EndTime has already passed.
        /// </summary>
        Preapproval_EndTimeAlreadyPassed,
        /// <summary>
        /// The preapproval is in the incorrect state for that action.
        /// </summary>
        Preapproval_InvalidStateForAction,
        /// <summary>
        /// You have tried to authorize the payment method unsuccessfully too many times with this preapproval
        /// </summary>
        Preapproval_TooManyUnsuccessfulAuthorizationAttempts,
        /// <summary>
        /// You are trying to make a payment to an account that this preapproval is not tied to.
        /// </summary>
        Preapproval_AccountPreapprovalMismatch,
        /// <summary>
        /// You have already executed as many checkouts on this period as you are allowed to based on the frequency parameter you set.
        /// </summary>
        Preapproval_CheckoutFrequencyExceeded,
        /// <summary>
        /// You have already reached the amount per period limit you set for this preapproval.
        /// </summary>
        Preapproval_AmountPerPeriodExceeded,
        /// <summary>
        /// You tried to execute two simultaenous payments on a single preapproval.
        /// </summary>
        Preapproval_SimultaneousPaymentExecution,
        /// <summary>
        /// The withdrawal you are trying to access does not exist.
        /// </summary>
        Withdrawal_DoesNotExist = 6001,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that withdrawal.
        /// </summary>
        Withdrawal_InsufficientPermissions,
        /// <summary>
        /// You are trying to access a user that does not exist or that you do not have permission to access.
        /// </summary>
        User_InsufficientPermissions = 7001,
        /// <summary>
        /// The user is an invalid state for that action.
        /// </summary>
        User_InvalidStateForAction,
        /// <summary>
        /// The user has been deleted.
        /// </summary>
        User_Deleted,
        /// <summary>
        /// The subscription plan you are trying to view/modify does not exist.
        /// </summary>
        Settlement_DoesNotExist = 8001,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that subscription plan.
        /// </summary>
        Settlement_InsufficientPermissionsToAccessOrModifySubscriptionPlan,
        /// <summary>
        /// The app cannot access the subscription plan.
        /// </summary>
        Settlement_AppCannotAccessSubscriptionPlan,
        /// <summary>
        /// The subscription plan has been deleted.
        /// </summary>
        Settlement_SubscriptionPlanDeleted,
        /// <summary>
        /// The subscription you are trying to view/modify does not exist
        /// </summary>
        Settlement_SubscriptionPlanDoesNotExist,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that subscription.
        /// </summary>
        Settlement_InsufficientPermissionsToAccessOrModifySubscription,
        /// <summary>
        /// The app cannot access the subscription.
        /// </summary>
        Settlement_AppCannotAccessSubscription,
        /// <summary>
        /// The subscription you are trying to view/modify has expired.
        /// </summary>
        Settlement_SubscriptionExpired,
        /// <summary>
        /// The subscription charge you are trying to view/modify does not exist.
        /// </summary>
        Settlement_SubscriptionChangeDoesNotExist,
        /// <summary>
        /// The AccessToken you have passed belongs to a user that does not have permission to view/modify that subscription charge.
        /// </summary>
        Settlement_InsufficientPermissionsToAccessOrModifySubscriptionChange,
        /// <summary>
        /// The app cannot access that subscription charge.
        /// </summary>
        Settlement_AppCannotAccessSubscriptionCharge
    }
}