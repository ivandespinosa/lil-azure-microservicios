namespace Lil.Search.Models
{
    public class Order
    {
        public string Id { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public string CustomerId { get; set; } = string.Empty;
        public double Total { get; set; }
        public List<OrderItem> Items { get; set; } = new();
    }
}
