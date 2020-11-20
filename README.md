#### Usage

```c#
    var getRateRequest = new GetRateRequest
    {
        ExportType = ExportType.Xml,
        FilterByOptions = new List<FilterByOption>
        {
            new FilterByOption { Field = "CurrencyCode", Value = "EUR" }, 
            new FilterByOption { Field = "CurrencyCode", Value = "USD" },
            new FilterByOption { Field = "CurrencyCode", Value = "GBP" }
        },
        OrderByOptions = new List<OrderByOption> { new OrderByOption { OrderType = OrderType.Descending, Field = "BanknoteBuying" } }
    };

    ITCMBService service = new TCMBService();

    GetRateResponse getRateResponse = service.ExportTodaysCurrencyRates(getRateRequest);
```

#### Libraries used

CsvHelper `https://joshclose.github.io/CsvHelper/`

xUnit `https://xunit.net/`

#### Build
~~~
dotnet restore
dotnet build
~~~


#### Running tests
~~~
dotnet restore
dotnet test
~~~