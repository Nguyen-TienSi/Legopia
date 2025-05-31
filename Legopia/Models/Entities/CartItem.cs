using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("cart_items")]
    [PrimaryKey(nameof(CartId), nameof(ProductId))]
    public class CartItem
    {
        [ForeignKey(nameof(Cart))]
        [Column("cart_id")]
        public string? CartId { get; set; }
        public Cart? Cart { get; set; }
        [ForeignKey(nameof(Product))]
        [Column("product_id")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
