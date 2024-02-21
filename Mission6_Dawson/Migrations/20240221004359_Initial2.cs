using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Dawson.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Movies",
                newName: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "MovieID");
        }
    }
}
