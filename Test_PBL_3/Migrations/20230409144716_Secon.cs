using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_PBL_3.Migrations
{
    /// <inheritdoc />
    public partial class Secon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_MovieID",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_MovieID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "Cinemas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "Cinemas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieID",
                table: "Movies",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_MovieID",
                table: "Movies",
                column: "MovieID",
                principalTable: "Cinemas",
                principalColumn: "ID");
        }
    }
}
