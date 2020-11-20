namespace TCMBApi.Dtos
{
    /// <summary>
    /// Initializes a new instance of the Rate class.
    /// </summary>
    public class Rate
    {
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public byte Unit { get; set; }
        public decimal ForexBuying { get; set; }
        public decimal ForexSelling { get; set; }
        public decimal BanknoteBuying { get; set; }
        public decimal BanknoteSelling { get; set; }
    }
}