namespace Auction.Domain.Modeles
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double StaringPrice { get; set; }
        public double CurrentPrice { get; set; }
        public DateTime EndDate { get; set; }
        public string? Image { get; set; }
    }
}
