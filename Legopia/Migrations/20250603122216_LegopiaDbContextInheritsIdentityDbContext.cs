using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Legopia.Migrations
{
    /// <inheritdoc />
    public partial class LegopiaDbContextInheritsIdentityDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_user_details_user_details_id",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_user_details_user_details_id",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_user_details_user_details_id",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_post_tags_posts_post_id",
                table: "post_tags");

            migrationBuilder.DropForeignKey(
                name: "FK_post_tags_tags_tag_id",
                table: "post_tags");

            migrationBuilder.DropForeignKey(
                name: "FK_posts_user_details_author_id",
                table: "posts");

            migrationBuilder.DropForeignKey(
                name: "FK_product_image_joinings_product_images_product_image_id",
                table: "product_image_joinings");

            migrationBuilder.DropForeignKey(
                name: "FK_product_image_joinings_products_product_id",
                table: "product_image_joinings");

            migrationBuilder.DropForeignKey(
                name: "FK_reviews_user_details_user_details_id",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_details_joining_user_details_UserDetailsId",
                schema: "identity",
                table: "user_role_details_joining");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_details_joining_user_roles_UserRoleId",
                schema: "identity",
                table: "user_role_details_joining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user_details",
                table: "user_details");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product_image_joinings",
                table: "product_image_joinings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_post_tags",
                table: "post_tags");

            migrationBuilder.RenameTable(
                name: "user_roles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "user_details",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "product_image_joinings",
                newName: "product_image_joining");

            migrationBuilder.RenameTable(
                name: "post_tags",
                newName: "post_tag_joining");

            migrationBuilder.RenameIndex(
                name: "IX_product_image_joinings_product_image_id",
                table: "product_image_joining",
                newName: "IX_product_image_joining_product_image_id");

            migrationBuilder.RenameIndex(
                name: "IX_post_tags_tag_id",
                table: "post_tag_joining",
                newName: "IX_post_tag_joining_tag_id");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_product_image_joining",
                table: "product_image_joining",
                columns: new[] { "product_id", "product_image_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_post_tag_joining",
                table: "post_tag_joining",
                columns: new[] { "post_id", "tag_id" });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_AspNetUsers_user_details_id",
                table: "addresses",
                column: "user_details_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_AspNetUsers_user_details_id",
                table: "carts",
                column: "user_details_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_AspNetUsers_user_details_id",
                table: "orders",
                column: "user_details_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_post_tag_joining_posts_post_id",
                table: "post_tag_joining",
                column: "post_id",
                principalTable: "posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_post_tag_joining_tags_tag_id",
                table: "post_tag_joining",
                column: "tag_id",
                principalTable: "tags",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_AspNetUsers_author_id",
                table: "posts",
                column: "author_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_product_image_joining_product_images_product_image_id",
                table: "product_image_joining",
                column: "product_image_id",
                principalTable: "product_images",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_product_image_joining_products_product_id",
                table: "product_image_joining",
                column: "product_id",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_AspNetUsers_user_details_id",
                table: "reviews",
                column: "user_details_id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_details_joining_AspNetRoles_UserRoleId",
                schema: "identity",
                table: "user_role_details_joining",
                column: "UserRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_details_joining_AspNetUsers_UserDetailsId",
                schema: "identity",
                table: "user_role_details_joining",
                column: "UserDetailsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_addresses_AspNetUsers_user_details_id",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_carts_AspNetUsers_user_details_id",
                table: "carts");

            migrationBuilder.DropForeignKey(
                name: "FK_orders_AspNetUsers_user_details_id",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_post_tag_joining_posts_post_id",
                table: "post_tag_joining");

            migrationBuilder.DropForeignKey(
                name: "FK_post_tag_joining_tags_tag_id",
                table: "post_tag_joining");

            migrationBuilder.DropForeignKey(
                name: "FK_posts_AspNetUsers_author_id",
                table: "posts");

            migrationBuilder.DropForeignKey(
                name: "FK_product_image_joining_product_images_product_image_id",
                table: "product_image_joining");

            migrationBuilder.DropForeignKey(
                name: "FK_product_image_joining_products_product_id",
                table: "product_image_joining");

            migrationBuilder.DropForeignKey(
                name: "FK_reviews_AspNetUsers_user_details_id",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_details_joining_AspNetRoles_UserRoleId",
                schema: "identity",
                table: "user_role_details_joining");

            migrationBuilder.DropForeignKey(
                name: "FK_user_role_details_joining_AspNetUsers_UserDetailsId",
                schema: "identity",
                table: "user_role_details_joining");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_product_image_joining",
                table: "product_image_joining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_post_tag_joining",
                table: "post_tag_joining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "product_image_joining",
                newName: "product_image_joinings");

            migrationBuilder.RenameTable(
                name: "post_tag_joining",
                newName: "post_tags");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "user_details");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "user_roles");

            migrationBuilder.RenameIndex(
                name: "IX_product_image_joining_product_image_id",
                table: "product_image_joinings",
                newName: "IX_product_image_joinings_product_image_id");

            migrationBuilder.RenameIndex(
                name: "IX_post_tag_joining_tag_id",
                table: "post_tags",
                newName: "IX_post_tags_tag_id");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "user_details",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "user_details",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "user_details",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "user_details",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "user_roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "user_roles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_product_image_joinings",
                table: "product_image_joinings",
                columns: new[] { "product_id", "product_image_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_post_tags",
                table: "post_tags",
                columns: new[] { "post_id", "tag_id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_details",
                table: "user_details",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user_roles",
                table: "user_roles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_addresses_user_details_user_details_id",
                table: "addresses",
                column: "user_details_id",
                principalTable: "user_details",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_user_details_user_details_id",
                table: "carts",
                column: "user_details_id",
                principalTable: "user_details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_user_details_user_details_id",
                table: "orders",
                column: "user_details_id",
                principalTable: "user_details",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_post_tags_posts_post_id",
                table: "post_tags",
                column: "post_id",
                principalTable: "posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_post_tags_tags_tag_id",
                table: "post_tags",
                column: "tag_id",
                principalTable: "tags",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_user_details_author_id",
                table: "posts",
                column: "author_id",
                principalTable: "user_details",
                principalColumn: "Id");

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
                name: "FK_reviews_user_details_user_details_id",
                table: "reviews",
                column: "user_details_id",
                principalTable: "user_details",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_details_joining_user_details_UserDetailsId",
                schema: "identity",
                table: "user_role_details_joining",
                column: "UserDetailsId",
                principalTable: "user_details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_role_details_joining_user_roles_UserRoleId",
                schema: "identity",
                table: "user_role_details_joining",
                column: "UserRoleId",
                principalTable: "user_roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
