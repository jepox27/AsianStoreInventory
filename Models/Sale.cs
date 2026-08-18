namespace AsianStoreInventory.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = "";

        public int Quantity { get; set; }

        public decimal Total { get; set; }

        public string Date { get; set; } = "";
    }
}