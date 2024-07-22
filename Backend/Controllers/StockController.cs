using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class StockController : ControllerBase
{
    private readonly ILogger<StockController> _logger;

    public StockController(ILogger<StockController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Stock> Get()
    {
        _logger.LogInformation("Get endpoint hit");
        return new List<Stock>
        {
            new Stock { Symbol = "AAPL", Name = "Apple Inc.", Price = 150.25M, MarketCap = 2000000, PERatio = 15.5M, DividendYield = 0.6M },
            new Stock { Symbol = "GOOGL", Name = "Alphabet Inc.", Price = 2750.30M, MarketCap = 1500000, PERatio = 30.0M, DividendYield = 0.0M }
        };
    }
}