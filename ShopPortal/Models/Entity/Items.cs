namespace ShopPortal.Models.Entity
{
    public class Items
    {
        public Guid Id { get; set; }
        public string? Item { get; set; }
        public double Price { get; set; }    
        public int Quantity { get; set; }
        public double Total { get; set; }
    }
}
