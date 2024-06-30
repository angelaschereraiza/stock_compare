using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class StockController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Stock> Get()
    {
        return new List<Stock>
        {
            new Stock { Symbol = "AAPL", Name = "Apple Inc.", Price = 150.25M, MarketCap = 2000000, PERatio = 15.5M, DividendYield = 0.6M },
            new Stock { Symbol = "GOOGL", Name = "Alphabet Inc.", Price = 2750.30M, MarketCap = 1500000, PERatio = 30.0M, DividendYield = 0.0M }
        };
    }
}