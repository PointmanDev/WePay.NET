using WePayApi.Shared;

namespace WePayApi.FileUpload.Common
{
    public class FileTypes : WePayValues<FileTypes>
    {
        public enum Choices : int
        {
            Passport = 0,
            DriversLicense,
            OtherGovernmentIssuedPhotoId,
            CurrentLeaseContract,
            CurrentUtilityBill,
            BenefitsCard,
            BirthCertificate,
            CertificateOfCitizenship,
            CertificateOfNaturalization,
            CertifiedCopyOfCourtOrder,
            EmploymentAuthorizationCard,
            PermanentResidenceCard,
            SocialSecurityCard,
            SocialInsuranceNumberCard,
            EvidenceOfCorporateRegistration,
            EvidenceOfNonprofitRegistration,
            EvidenceOfAuthority,
            CurrentBankStatement,
            CurrentLocalTaxBill,
            MortgageStatement,
            ElectoralRegisterEntry
        }

        public const string Passport = "passport";
        public const string DriversLicense = "drivers_license";
        public const string OtherGovernmentIssuedPhotoId = "other_government_issued_photo_id";
        public const string CurrentLeaseContract = "current_lease_contract";
        public const string CurrentUtilityBill = "current_utility_bill";
        public const string BenefitsCard = "benefits_card";
        public const string BirthCertificate = "birth_certificate";
        public const string CertificateOfCitizenship = "certificate_of_citizenship";
        public const string CertificateOfNaturalization = "certificate_of_naturalization";
        public const string CertifiedCopyOfCourtOrder = "certified_copy_of_court_order";
        public const string EmploymentAuthorizationCard = "employment_authorization_card";
        public const string PermanentResidenceCard = "permanent_residence_card";
        public const string SocialSecurityCard = "social_security_card";
        public const string SocialInsuranceNumberCard = "social_insurance_number_card";
        public const string EvidenceOfCorporateRegistration = "evidence_of_corporate_registration";
        public const string EvidenceOfNonprofitRegistration = "evidence_of_nonprofit_registration";
        public const string EvidenceOfAuthority = "evidence_of_authority";
        public const string CurrentBankStatement = "current_bank_statement";
        public const string CurrentLocalTaxBill = "current_local_tax_bill";
        public const string MortgageStatement = "mortgage_statement";
        public const string ElectoralRegisterEntry = "electoral_register_entry";
    }
}