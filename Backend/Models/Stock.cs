public class Stock
{
    public string Symbol { get; set; } = null!;
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal MarketCap { get; set; }
    public decimal PERatio { get; set; }
    public decimal DividendYield { get; set; }
}