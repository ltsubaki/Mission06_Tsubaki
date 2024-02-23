using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace missionSixLilian.Migrations
{
    /// <inheritdoc />
    public partial class initial8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Movies",
                newName: "CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryNameCategoryId",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Catergories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catergories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Catergories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Miscellaneous" },
                    { 2, "Drama" },
                    { 3, "Television" },
                    { 4, "Horror/Suspense" },
                    { 5, "Comedy" },
                    { 6, "Family" },
                    { 7, "Action/Adventure" },
                    { 8, "VHS" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CategoryNameCategoryId",
                table: "Movies",
                column: "CategoryNameCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Catergories_CategoryNameCategoryId",
                table: "Movies",
                column: "CategoryNameCategoryId",
                principalTable: "Catergories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Catergories_CategoryNameCategoryId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Catergories");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CategoryNameCategoryId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CategoryNameCategoryId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Movies",
                newName: "Category");
        }
    }
}
