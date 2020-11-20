using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using TCMBApi.Contracts;
using TCMBApi.Dtos;

namespace TCMBApi.Exporters
{
    /// <summary>
    /// Initializes a new instance of the XmlExporter class.
    /// </summary>
    internal class XmlExporter : IExportable
    {
        /// <summary>
        /// Export to XML File
        /// </summary>
        /// <param name="rates"></param>
        /// <param name="path"></param>
        public void Export(List<Rate> rates, string path)
        {
            var writer = new XmlSerializer(typeof(List<Rate>));

            FileStream file = File.Create(path);

            writer.Serialize(file, rates);

            file.Close();
        }
    }
}