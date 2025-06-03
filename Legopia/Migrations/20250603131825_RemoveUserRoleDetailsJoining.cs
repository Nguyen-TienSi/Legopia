using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Legopia.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUserRoleDetailsJoining : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_role_details_joining",
                schema: "identity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "identity");

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
                        name: "FK_user_role_details_joining_AspNetRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_role_details_joining_AspNetUsers_UserDetailsId",
                        column: x => x.UserDetailsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_user_role_details_joining_UserRoleId",
                schema: "identity",
                table: "user_role_details_joining",
                column: "UserRoleId");
        }
    }
}
