namespace TCMBApi.Dtos
{
    /// <summary>
    /// Initializes a new instance of the GetRateResponse class.
    /// </summary>
    public class GetRateResponse
    {
        public bool HasError { get; set; }
        public string ErrorMessage { get; set; }
        public string ExportedPath { get; set; }
    }
}