using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("order_details")]
    [PrimaryKey(nameof(OrderId), nameof(ProductId))]
    public class OrderItem
    {
        [Column("quantity")]
        public int Quantity { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        // Many to one relationship
        [ForeignKey(nameof(OrderDetails))]
        [Column("order_id")]
        public int? OrderId { get; set; }
        public OrderDetails? OrderDetails { get; set; }
        [ForeignKey(nameof(Product))]
        [Column("product_id")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
