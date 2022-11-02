namespace Lil.Search.Models
{
    public class OrderItem
    {
        public string OrderId { get; set; } = string.Empty;
        public int Id { get; set; }
        public string ProductId { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; } = new();
    }
}
