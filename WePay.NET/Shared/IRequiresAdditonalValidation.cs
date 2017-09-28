namespace WePay.Shared
{
    public interface IRequiresAdditonalValidation
    {
        string GetAdditonalValidationErrorMessage();
    }
}