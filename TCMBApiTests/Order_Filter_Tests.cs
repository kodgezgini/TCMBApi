using System.Collections.Generic;
using System.Linq;
using TCMBApi.Dtos;
using Xunit;

namespace TCMBApiTests
{
    public class Order_Filter_Tests
    {
        public static List<Rate> RatesData => new List<Rate>
        {
             new Rate
                {
                    CurrencyCode = "USD",
                    CurrencyName = "US DOLLAR",
                    BanknoteBuying = 5,
                    BanknoteSelling = 6,
                    ForexBuying = 5,
                    ForexSelling = 6
                },
                new Rate
                {
                    CurrencyCode = "EUR",
                    CurrencyName = "EUR",
                    BanknoteBuying = 10,
                    BanknoteSelling = 11,
                    ForexBuying = 10,
                    ForexSelling = 11
                },
                new Rate
                {
                    CurrencyCode = "GBP",
                    CurrencyName = "POUND",
                    BanknoteBuying = 15,
                    BanknoteSelling = 16,
                    ForexBuying = 15,
                    ForexSelling = 16
                }
        };

        [Fact]
        public void ApplyOrderByAscending_CurrencyCode_Test()
        {
            var orderedRates = TCMBApi.TCMBServiceHelpers.ApplyOrderByAscending(RatesData.AsQueryable(), "CurrencyCode");

            Assert.Equal("EUR", orderedRates.First().CurrencyCode);
        }

        [Fact]
        public void ApplyOrderByDescending_BanknoteBuying_Test()
        {
            var orderedRates = TCMBApi.TCMBServiceHelpers.ApplyOrderByDescending(RatesData.AsQueryable(), "BanknoteBuying");

            Assert.Equal(15, orderedRates.First().BanknoteBuying);
        }

        [Fact]
        public void ApplyFilterBy_CurrencyCode_Test()
        {
            var orderedRates = TCMBApi.TCMBServiceHelpers.ApplyFilterBy(RatesData.AsQueryable(), "CurrencyCode", "GBP");

            Assert.Equal("GBP", orderedRates.First().CurrencyCode);
        }
    }
}