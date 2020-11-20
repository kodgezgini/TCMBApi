using System.Collections.Generic;
using TCMBApi.Dtos;

namespace TCMBApi.Contracts
{
    /// <summary>
    /// IExportable
    /// </summary>
    internal interface IExportable
    {
        void Export(List<Rate> rates, string path);
    }
}