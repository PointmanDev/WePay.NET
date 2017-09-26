namespace WePayApi.Checkout.Common
{
    /// <summary>
    /// All recognized Banking Error Codes
    /// </summary>
    public static class PaymentBankPaymentErrors
    {
        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string InsufficientFundsInAccount = "R01";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string AccountIsClosed = "R02";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string NoAccountOnFile = "R03";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string InvalidAccountNumber = "R04";

        /// <summary>
        /// Bank rejected payment request, no follow-up suggested.
        /// </summary>
        public const string UnauthorizedDebitToConsumerAccount = "R05";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string ReturnedAtRequestOfOriginatingBank = "R06";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string AuthorizationRevokedByCustomer = "R07";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string PaymentStopped = "R08";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string InsufficientCollectedFundsInAccountBeingCharged = "R09";

        /// <summary>
        /// Bank rejected payment request, no follow-up suggested.
        /// </summary>
        public const string CustomerAdvisesNotAuthorizedOrAmountIncorrect = "R10";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R11 = "Check truncation return";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R12 = "Account sold to another financial institution";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R13 = "Invalid ACH routing number";

        /// <summary>
        /// Bank rejected payment request, no follow-up suggested.
        /// </summary>
        public const string R14 = "Payee is deceased";

        /// <summary>
        /// Bank rejected payment request, no follow-up suggested.
        /// </summary>
        public const string R15 = "Account holder is deceased";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R16 = "Account funds have been frozen";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R17 = "Item returned because of invalid data";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R18 = "Improper effective date";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R19 = "Amount error";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R20 = "Account does not allow ACH transactions or limit has been exceeded";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R21 = "Invalid company identification";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R22 = "Invalid individual ID";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R23 = "Credit entry refused by receiver";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R24 = "Duplicate entry";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R25 = "Addenda record error";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R26 = "Mandatory field error";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R27 = "Trace number error";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R28 = "Routing/transit number check digit error";

        /// <summary>
        /// Bank rejected payment request, no follow-up suggested.
        /// </summary>
        public const string R29 = "Corporate customer advised not authorized";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R30 = "RDFI not participant in check truncation program";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R31 = "Permissible return entry";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R32 = "Receiving bank non-settlement";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R33 = "Return of item";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R34 = "Limited participation originating bank";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R35 = "Return of improper debit entry";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R36 = "Return of improper credit entry";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R37 = "Source document presented for payment";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R38 = "Stop payment on source document";

        /// <summary>
        /// Bank system error.
        /// Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R39 = "Improper source document";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R40 = "Return of item by government agency";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R41 = "Invalid Transaction Code";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R42 = "Routing/transit number check digit error";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R43 = "Invalid account number";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R44 = "Invalid individual ID";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R45 = "Invalid individual or company name";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R46 = "Invalid payee indicator code";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account
        /// </summary>
        public const string R47 = "Duplicate enrollment";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R50 = "State law affecting RCK acceptance";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R51 = "Item is ineligible, notice not provided, signature not genuine, or original item altered for adjustment entry";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R52 = "Stop payment on item";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R53 = "Item and ACH entry presented for payment";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R61 = "Misrouted return - RDFI has placed incorrect routing/transit # in RDFI id field";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R67 = "Duplicate return";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R68 = "Untimely return - the return was not sent within the established timeframe";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R69 = "Field errors";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R70 = "Permissible return entry not accepted";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R71 = "Misrouted dishonored return - incorrect routing/transit # in RDFI id field";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R72 = "Untimely return - dishonored return was not sent within the established timeframe";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R73 = "Timely original return - RDFI certifies the original return entry was sent within established timeframe for original returns";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R74 = "Corrected return - RDFI is correcting a previous return entry that was dishonored because it contained incomplete or incorrect information";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R75 = "Original return not a duplicate";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R76 = "No errors found";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R80 = "Cross-border payment coding error";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R81 = "Non-participant in cross-border program";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R82 = "Invalid foreign RDFI identification";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R83 = "Foreign RDFI unable to settle";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R84 = "Cross-border entry not processed by originating gateway operator";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R94 = "Administrative return item was processed and resubmitted as a photocopy";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R95 = "Administrative return item was processed and resubmitted as a MICR-Split";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R97 = "Administrative return item was processed and resubmitted with corrected dollar amount";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R98 = "Indicates a return PAC (pre-authorized check); RDFI provides a text reason and indicated a new account number on the PAC itself";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string R99 = "Indicates a return PAC (pre-authorized check); RDFI provides a text reason on the PAC itself for which there is no equivalent return reason code";
    }
}