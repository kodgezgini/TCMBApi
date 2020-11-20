using TCMBApi.Contracts;
using TCMBApi.Dtos;

namespace TCMBApi.Exporters
{
    /// <summary>
    /// Exporter Factory Class
    /// </summary>
    internal class ExporterFactory
    {
        /// <summary>
        /// Create IExportable given by the export type (Csv or Xml)
        /// </summary>
        /// <param name="exportType"></param>
        /// <returns>IExportable</returns>
        public static IExportable CreatExporter(ExportType exportType)
        {
            return exportType switch
            {
                ExportType.Csv => new CsvExporter(),
                ExportType.Xml => new XmlExporter(),
                _ => new CsvExporter()
            };
        }
    }
}