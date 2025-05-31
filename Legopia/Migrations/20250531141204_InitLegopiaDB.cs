using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Legopia.Migrations
{
    /// <inheritdoc />
    public partial class InitLegopiaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.CreateTable(
                name: "coupons",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coupon_code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    discount_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount_percentage = table.Column<float>(type: "real", nullable: true),
                    minimum_order_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    expiration_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    coupon_status = table.Column<int>(type: "int", nullable: false),
                    usage_limit = table.Column<int>(type: "int", nullable: true),
                    used_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coupons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "post_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    post_category_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product_images",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    image_url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_images", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tag_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "user_details",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "user_roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    short_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount_price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    discount_percentage = table.Column<float>(type: "real", nullable: true),
                    thumbnail_url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    product_category_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_product_categories_product_category_id",
                        column: x => x.product_category_id,
                        principalTable: "product_categories",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_details_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_addresses_user_details_user_details_id",
                        column: x => x.user_details_id,
                        principalTable: "user_details",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    user_details_id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.user_details_id);
                    table.ForeignKey(
                        name: "FK_carts_user_details_user_details_id",
                        column: x => x.user_details_id,
                        principalTable: "user_details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    post_status = table.Column<int>(type: "int", nullable: false),
                    author_id = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                    table.ForeignKey(
                        name: "FK_posts_post_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "post_categories",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_posts_user_details_author_id",
                        column: x => x.author_id,
                        principalTable: "user_details",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "user_role_details_joining",
                schema: "identity",
                columns: table => new
                {
                    UserDetailsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_role_details_joining", x => new { x.UserDetailsId, x.UserRoleId });
                    table.ForeignKey(
                        name: "FK_user_role_details_joining_user_details_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "user_details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_role_details_joining_user_roles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "user_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product_image_joinings",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_image_joinings", x => new { x.ProductId, x.ProductImageId });
                    table.ForeignKey(
                        name: "FK_product_image_joinings_product_images_ProductImageId",
                        column: x => x.ProductImageId,
                        principalTable: "product_images",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_product_image_joinings_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: true),
                    user_details_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.id);
                    table.ForeignKey(
                        name: "FK_reviews_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_reviews_user_details_user_details_id",
                        column: x => x.user_details_id,
                        principalTable: "user_details",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    order_status = table.Column<int>(type: "int", nullable: false),
                    order_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    shipping_address = table.Column<int>(type: "int", nullable: true),
                    user_details_id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_orders_addresses_shipping_address",
                        column: x => x.shipping_address,
                        principalTable: "addresses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_orders_user_details_user_details_id",
                        column: x => x.user_details_id,
                        principalTable: "user_details",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "cart_items",
                columns: table => new
                {
                    cart_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cart_items", x => new { x.cart_id, x.product_id });
                    table.ForeignKey(
                        name: "FK_cart_items_carts_cart_id",
                        column: x => x.cart_id,
                        principalTable: "carts",
                        principalColumn: "user_details_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cart_items_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "post_tags",
                columns: table => new
                {
                    post_id = table.Column<int>(type: "int", nullable: false),
                    tag_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_tags", x => new { x.post_id, x.tag_id });
                    table.ForeignKey(
                        name: "FK_post_tags_posts_post_id",
                        column: x => x.post_id,
                        principalTable: "posts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_post_tags_tags_tag_id",
                        column: x => x.tag_id,
                        principalTable: "tags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_coupon_joining",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false),
                    coupon_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_coupon_joining", x => new { x.order_id, x.coupon_id });
                    table.ForeignKey(
                        name: "FK_order_coupon_joining_coupons_coupon_id",
                        column: x => x.coupon_id,
                        principalTable: "coupons",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_coupon_joining_orders_order_id",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_details",
                columns: table => new
                {
                    order_id = table.Column<int>(type: "int", nullable: false),
                    product_id = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_details", x => new { x.order_id, x.product_id });
                    table.ForeignKey(
                        name: "FK_order_details_orders_order_id",
                        column: x => x.order_id,
                        principalTable: "orders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_details_products_product_id",
                        column: x => x.product_id,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_addresses_user_details_id",
                table: "addresses",
                column: "user_details_id",
                unique: true,
                filter: "[user_details_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_cart_items_product_id",
                table: "cart_items",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_coupon_joining_coupon_id",
                table: "order_coupon_joining",
                column: "coupon_id");

            migrationBuilder.CreateIndex(
                name: "IX_order_details_product_id",
                table: "order_details",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_orders_shipping_address",
                table: "orders",
                column: "shipping_address",
                unique: true,
                filter: "[shipping_address] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_orders_user_details_id",
                table: "orders",
                column: "user_details_id");

            migrationBuilder.CreateIndex(
                name: "IX_post_tags_tag_id",
                table: "post_tags",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_posts_author_id",
                table: "posts",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_posts_category_id",
                table: "posts",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_product_image_joinings_ProductImageId",
                table: "product_image_joinings",
                column: "ProductImageId");

            migrationBuilder.CreateIndex(
                name: "IX_products_product_category_id",
                table: "products",
                column: "product_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_product_id",
                table: "reviews",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_user_details_id",
                table: "reviews",
                column: "user_details_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_details_joining_UserRoleId",
                schema: "identity",
                table: "user_role_details_joining",
                column: "UserRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cart_items");

            migrationBuilder.DropTable(
                name: "order_coupon_joining");

            migrationBuilder.DropTable(
                name: "order_details");

            migrationBuilder.DropTable(
                name: "post_tags");

            migrationBuilder.DropTable(
                name: "product_image_joinings");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "user_role_details_joining",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "coupons");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "product_images");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "user_roles");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "post_categories");

            migrationBuilder.DropTable(
                name: "product_categories");

            migrationBuilder.DropTable(
                name: "user_details");
        }
    }
}
