using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Legopia.Models.Entities
{
    [Table("products")]
    public class Product : BaseEntity
    {
        [Required]
        [Column("product_name")]
        public string ProductName { get; set; } = string.Empty;
        [Column("short_description")]
        public string ShortDescription { get; set; } = string.Empty;
        [Column("description")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Column("price")]
        public decimal Price { get; set; }
        [Column("discount_price")]
        public decimal? DiscountPrice { get; set; }
        [Column("discount_percentage")]
        public float? DiscountPercentage { get; set; }
        [Column("stock")]
        public int Stock { get; set; }
        // One to one relationship
        [ForeignKey(nameof(ThumbnailImage))]
        [Column("thumbnail_image_id")]
        public int? ThumbnailImageId { get; set; }
        public ProductImage? ThumbnailImage { get; set; }
        // One to many relationship
        public ICollection<ProductReview> Reviews { get; set; } = [];
        public ICollection<CartItem> CartItems { get; set; } = [];
        public ICollection<OrderItem> OrderItems { get; set; } = [];
        // Many to one relationship
        [ForeignKey(nameof(ProductCategory))]
        [Column("product_category_id")]
        public int? ProductCategoryId { get; set; }
        public ProductCategory? ProductCategory { get; set; }
        // Many to many relationship
        public ICollection<ProductImageJoining> ProductImageJoining { get; set; } = [];

        [NotMapped]
        public decimal FinalPrice
        {
            get
            {
                if (DiscountPercentage.HasValue && DiscountPercentage > 0)
                {
                    return Price - (Price * (decimal)DiscountPercentage.Value / 100);
                }
                return DiscountPrice ?? Price;
            }
        }
    }
}
