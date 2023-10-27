using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParkApi.Migrations
{
    public partial class UpdateZipCodeToYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "NationalParks",
                newName: "YearCreated");

            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "Name", "StateCode", "YearCreated" },
                values: new object[] { 1, "Voyageurs National Park", "MN", 1975 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "YearCreated",
                table: "NationalParks",
                newName: "ZipCode");
        }
    }
}
