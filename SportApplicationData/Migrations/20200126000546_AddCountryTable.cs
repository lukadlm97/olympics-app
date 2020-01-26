using Microsoft.EntityFrameworkCore.Migrations;

namespace SportApplicationData.Migrations
{
    public partial class AddCountryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Athletes",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Continent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Athletes_CountryId",
                table: "Athletes",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Athletes_Country_CountryId",
                table: "Athletes",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Athletes_Country_CountryId",
                table: "Athletes");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Athletes_CountryId",
                table: "Athletes");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Athletes");
        }
    }
}
