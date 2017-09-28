using System.Threading.Tasks;
using WePay.Shared;
using WePay.FileUpload.Request;
using WePay.FileUpload.Response;

namespace WePay.FileUpload
{
    /// <summary>
    /// The FileUpload API is a single endpoint that allows your application to upload documents on behalf of
    /// a merchant account for asynchronous risk and fraud review when WePay is unable to verify the merchant’s identity automatically.
    /// While WePay makes every effort not to create friction for your users, if we cannot verify a user’s identity through any other means,
    /// we will require the user to provide us with documents that prove their identity.
    /// All partners must be prepared for the possibility that their users (merchants) must upload documents.
    /// WePay uses a risk-based approach in deciding when your users must upload documents.
    /// Documents may be requested after your users have started accepting transactions and/or settled funds to their bank accounts.
    /// Once your user submits documents, the KYC state state changes from 'RequireDocs' to 'InReview' and the account state state
    /// changes from 'ActionRequired' to 'Active' because there is no further action required of the user.
    /// Documents are reviewed manually by WePay within two business days.
    /// If WePay is unable to verify the user’s identity with the documents provided,
    ///  the user will be required to upload additional documents.
    ///  The KYC state will return to 'RequireDocs' and the account state will return to 'ActionRequired'. 
    ///  WePay reserves the right to disable an account after multiple failed attempts at verifying users by examining their documents.
    ///  When your merchant’s KYC state changes to require_docs, your merchant should be notified that they must upload documents to finish account setup.
    ///  Your application will take the following steps to upload a document to WePay:
    ///  Make a FileUpload call for each document that needs to be uploaded.
    ///  Your application is returned a FileId for each uploaded document.
    ///  Call KnowYourCustomer Modify using the file IDs to confirm that the documents originated from a valid application.
    ///  Unconfirmed documents are not reviewed and are deleted after 30 minutes.
    ///  TIP: Your application may upload documents anytime using FileUpload,
    ///  but your application will not be able to call KnowYourCustomer Modify unless the merchant’s KYC state is 'RequireDocs'.
    /// </summary>
    public class FileUploadService : WePayApiService<FileUploadService.EndPointNames>
    {
        public enum EndPointNames : int
        {
            Upload = 0
        }

        /// <summary>
        /// TIP: The file size limit is 10 MB.
        ///  If your application attempts to upload a file in excess of 10 MB, a HTTP error code 413 is returned (request entity too large).
        /// </summary>
        /// <param name="uploadRequest"></param>
        /// <param name="accessToken"></param>
        /// <param name="useStaging"></param>
        /// <returns></returns>
        public async Task<UploadResponse> UploadAsync(UploadRequest uploadRequest,
                                                      string accessToken = null,
                                                      bool? useStaging = null)
        {
            return await PostRequestAsync(uploadRequest, EndPointUrls.Upload, accessToken, useStaging);
        }

        public static class EndPointUrls
        {
            public const string Upload = "file/upload";
        }

        public FileUploadService(bool enableValidation = false,
                                 string accessToken = null,
                                 bool useStaging = false) : base(enableValidation, accessToken, useStaging)
        {
            MapEndPointUrlsToEndPoints(typeof(EndPointUrls));
        }
    }
}