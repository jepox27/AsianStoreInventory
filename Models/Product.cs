using AsianStoreInventory.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsianStoreInventory.Models
{
    public class Product
    {
        [NotMapped]
        public int SellQuantity { get; set; } = 1;

        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Barcode { get; set; } = "";

        public string Category { get; set; } = "";

        public string Supplier { get; set; } = "";

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}