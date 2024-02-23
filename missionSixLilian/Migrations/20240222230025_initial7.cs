using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace missionSixLilian.Migrations
{
    /// <inheritdoc />
    public partial class initial7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieSubmissions",
                table: "MovieSubmissions");

            migrationBuilder.RenameTable(
                name: "MovieSubmissions",
                newName: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "MovieSubmissions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieSubmissions",
                table: "MovieSubmissions",
                column: "MovieId");
        }
    }
}
