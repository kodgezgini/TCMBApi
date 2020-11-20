using TCMBApi.Dtos;

namespace TCMBApi.Contracts
{
    /// <summary>
    /// ITCMBService
    /// </summary>
    public interface ITCMBService
    {
        GetRateResponse ExportTodaysCurrencyRates(GetRateRequest getRateRequest);
    }
}