using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_PBL_3.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_MovieID",
                table: "Actor_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actor_Movies_MovieID",
                table: "Actor_Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies",
                columns: new[] { "MovieID", "ActorID" });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_Movies_ActorID",
                table: "Actor_Movies",
                column: "ActorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_ActorID",
                table: "Actor_Movies",
                column: "ActorID",
                principalTable: "Actors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movies_Actors_ActorID",
                table: "Actor_Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actor_Movies_ActorID",
                table: "Actor_Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor_Movies",
                table: "Actor_Movies",
                columns: new[] { "ActorID", "MovieID" });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_Movies_MovieID",
                table: "Actor_Movies",
                column: "MovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movies_Actors_MovieID",
                table: "Actor_Movies",
                column: "MovieID",
                principalTable: "Actors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
