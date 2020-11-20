using CsvHelper;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TCMBApi.Contracts;
using TCMBApi.Dtos;

namespace TCMBApi.Exporters
{
    /// <summary>
    /// Initializes a new instance of the CsvExporter class.
    /// </summary>
    internal class CsvExporter : IExportable
    {
        /// <summary>
        /// Export to CSV File
        /// </summary>
        /// <param name="rates"></param>
        /// <param name="path"></param>
        public void Export(List<Rate> rates, string path)
        {
            using var writer = new StreamWriter(path);

            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);

            csv.WriteRecords((IEnumerable)rates);
        }
    }
}