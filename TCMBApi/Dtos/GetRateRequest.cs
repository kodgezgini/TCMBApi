using System.Collections.Generic;

namespace TCMBApi.Dtos
{
    /// <summary>
    /// Initializes a new instance of the GetRateRequest class.
    /// </summary>
    public class GetRateRequest
    {
        public ExportType ExportType { get; set; }
        public List<OrderByOption> OrderByOptions { get; set; }
        public List<FilterByOption> FilterByOptions { get; set; }
    }
}