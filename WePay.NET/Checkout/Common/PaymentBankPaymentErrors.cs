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
        public const string InvalidBankAccountNumber = "R04";

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
        public const string CheckTruncationReturn = "R11";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string AccountSoldToAnotherFinancialInstitution = "R12";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string InvalidAchRoutingNumber = "R13";

        /// <summary>
        /// Bank rejected payment request, no follow-up suggested.
        /// </summary>
        public const string PayeeIsDeceased = "R14";

        /// <summary>
        /// Bank rejected payment request, no follow-up suggested.
        /// </summary>
        public const string AccountHolderIsDeceased = "R15";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string AccountFundsHaveBeenFrozen = "R16";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string ItemReturnedBecauseOfInvalidData = "R17";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string ImproperEffectiveDate = "R18";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string AmountError = "R19";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string AccountDoesNotAllowAchTransactionsOrLimitHasBeenExceeded = "R20";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string InvalidCompanyIdentification = "R21";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string InvalidIndividualId = "R22";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string CreditEntryRefusedByReceiver = "R23";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string DuplicateEntry = "R24";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string AddendaRecordError = "R25";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string MandatoryFieldError = "R26";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string TraceNumberError = "R27";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string TransitRoutingNumberCheckDigitError = "R28";

        /// <summary>
        /// Bank rejected payment request, no follow-up suggested.
        /// </summary>
        public const string CorporateCustomerAdvisedNotAuthorized = "R29";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string RdfiNotParticipantInCheckTruncationProgram = "R30";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string PermissibleReturnEntry = "R31";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string ReceivingBankNonSettlement = "R32";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string ReturnOfItem = "R33";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string LimitedParticipationOriginatingBank = "R34";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string ReturnOfImproperDebitEntry = "R35";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string ReturnOfImproperCreditEntry = "R36";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string SourceDocumentPresentedForPayment = "R37";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string StopPaymentOnSourceDocument = "R38";

        /// <summary>
        /// Bank system error.
        /// Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string ImproperSourceDocument = "R39";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string ReturnOfItemByGovernmentAgency = "R40";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string InvalidTransactionCode = "R41";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string RoutingOrTransitNumberCheckDigitError = "R42";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string InvalidDfiAccountNumber = "R43";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string InvalidIndividualIdNumber = "R44";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string InvalidIndividualOrCompanyName = "R45";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string InvalidPayeeIndicatorCode = "R46";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account
        /// </summary>
        public const string DuplicateEnrollment = "R47";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string StateLawAffectingRckAcceptance = "R50";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string ItemIneligibleNoticeNotProvidedSignatureNotGenuineOrOriginalItemAlteredForAdjustmentEntry = "R51";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string StopPaymentOnItem = "R52";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string ItemAndAchEntryPresentedForPayment = "R53";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string MisroutedReturnRdfiHasPlacedIncorrectRoutingOrTransitNumberInRdfiIdField = "R61";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string DuplicateReturn = "R67";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string UntimelyReturnTheReturnWasNotSentWithinTheEstablishedTimeframe = "R68";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string FieldErrors = "R69";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string PermissibleReturnEntryNotAccepted = "R70";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string MisroutedDishonoredReturnIncorrectRoutingOrTransitNumberInRdfiIdField = "R71";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string UntimelyReturnDishonoredReturnWasNotSentWithinTheEstablishedTimeframe = "R72";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string R73 = "Timely original return - RDFI certifies the original return entry was sent within established timeframe for original returns";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string CorrectedReturnRdfiIsCorrectingAPreviousReturnEntryThatWasDishonoredBecauseItContainedIncompleteOrIncorrectInformation = "R74";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string OriginalReturnNotADuplicate = "R75";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string NoErrorsFound = "R76";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string CrossBorderPaymentCodingError = "R80";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string NonParticipantInCrossBorderProgram = "R81";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string InvalidForeignRdfiIdentification = "R82";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string ForeignRdfiUnableToSettle = "R83";

        /// <summary>
        /// Payer needs to resubmit payment with updated account information or a new account.
        /// </summary>
        public const string CrossBorderEntryNotProcessedByOriginatingGatewayOperator = "R84";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string AdministrativeReturnItemWasProcessedAndResubmittedAsAPhotocopy = "R94";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string AdministrativeReturnItemWasProcessedAndResubmittedAsAMicrSplit = "R95";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string AdministrativeReturnItemWasProcessedAndResubmittedWithCorrectedDollarAmount = "R97";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string IndicatesAReturnPreAuthorizedCheckRdfiProvidesATextReasonAndIndicatedANewAccountNumberOnThePacItself = "R98";

        /// <summary>
        /// Bank system error. Customer needs to use a different bank account, preferably at a different bank.
        /// </summary>
        public const string IndicatesAReturnPreAuthorizedCheckRdfiProvidesATextReasonOnThePacItselfForWhichThereIsNoEquivalentReturnReasonCode = "R99";
    }
}