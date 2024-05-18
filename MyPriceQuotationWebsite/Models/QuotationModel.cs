namespace MyPriceQuotationWebsite.Models
{
    public class QuotationModel
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public string Symbol { get; set; }
        public decimal Value { get; set; }
    }
}
