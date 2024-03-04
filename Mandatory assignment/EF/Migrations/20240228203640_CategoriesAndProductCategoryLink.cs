using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Compulsory_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesAndProductCategoryLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId_FK",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId_FK",
                table: "Products",
                column: "CategoryId_FK");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId_FK",
                table: "Products",
                column: "CategoryId_FK",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId_FK",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId_FK",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CategoryId_FK",
                table: "Products");
        }
    }
}
