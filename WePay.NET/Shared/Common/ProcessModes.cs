namespace WePayApi.Shared.Common
{
    /// <summary>
    /// All possible modes the process will be displayed in.
    /// Choose iframe if you would like to frame the process on your site.
    /// </summary>
    public class ProcessModes : WePayValues<ProcessModes>
    {
        public enum Choices : int
        {
            Regular,
            Iframe
        }

        public const string Regular = "regular";
        public const string Iframe = "iframe";
    }
}