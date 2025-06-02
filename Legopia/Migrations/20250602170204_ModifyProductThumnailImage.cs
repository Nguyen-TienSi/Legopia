using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Legopia.Migrations
{
    /// <inheritdoc />
    public partial class ModifyProductThumnailImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_image_joinings_product_images_ProductImageId",
                table: "product_image_joinings");

            migrationBuilder.DropForeignKey(
                name: "FK_product_image_joinings_products_ProductId",
                table: "product_image_joinings");

            migrationBuilder.DropColumn(
                name: "thumbnail_url",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "image_url",
                table: "product_images",
                newName: "image_file_name");

            migrationBuilder.RenameColumn(
                name: "ProductImageId",
                table: "product_image_joinings",
                newName: "product_image_id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "product_image_joinings",
                newName: "product_id");

            migrationBuilder.RenameIndex(
                name: "IX_product_image_joinings_ProductImageId",
                table: "product_image_joinings",
                newName: "IX_product_image_joinings_product_image_id");

            migrationBuilder.AddColumn<int>(
                name: "thumbnail_image_id",
                table: "products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "image_data",
                table: "product_images",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.CreateIndex(
                name: "IX_products_thumbnail_image_id",
                table: "products",
                column: "thumbnail_image_id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_image_joinings_product_images_product_image_id",
                table: "product_image_joinings",
                column: "product_image_id",
                principalTable: "product_images",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_image_joinings_products_product_id",
                table: "product_image_joinings",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_product_images_thumbnail_image_id",
                table: "products",
                column: "thumbnail_image_id",
                principalTable: "product_images",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_product_image_joinings_product_images_product_image_id",
                table: "product_image_joinings");

            migrationBuilder.DropForeignKey(
                name: "FK_product_image_joinings_products_product_id",
                table: "product_image_joinings");

            migrationBuilder.DropForeignKey(
                name: "FK_products_product_images_thumbnail_image_id",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_thumbnail_image_id",
                table: "products");

            migrationBuilder.DropColumn(
                name: "thumbnail_image_id",
                table: "products");

            migrationBuilder.DropColumn(
                name: "image_data",
                table: "product_images");

            migrationBuilder.RenameColumn(
                name: "image_file_name",
                table: "product_images",
                newName: "image_url");

            migrationBuilder.RenameColumn(
                name: "product_image_id",
                table: "product_image_joinings",
                newName: "ProductImageId");

            migrationBuilder.RenameColumn(
                name: "product_id",
                table: "product_image_joinings",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_product_image_joinings_product_image_id",
                table: "product_image_joinings",
                newName: "IX_product_image_joinings_ProductImageId");

            migrationBuilder.AddColumn<string>(
                name: "thumbnail_url",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_product_image_joinings_product_images_ProductImageId",
                table: "product_image_joinings",
                column: "ProductImageId",
                principalTable: "product_images",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_image_joinings_products_ProductId",
                table: "product_image_joinings",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
