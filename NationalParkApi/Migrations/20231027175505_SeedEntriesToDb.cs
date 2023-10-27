using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParkApi.Migrations
{
    public partial class SeedEntriesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NationalParks",
                columns: new[] { "NationalParkId", "Name", "StateCode", "YearCreated" },
                values: new object[,]
                {
                    { 2, "Grand Portage National Monument", "MN", 1778 },
                    { 3, "Crater Lake National Park", "OR", 1902 },
                    { 4, "Mount Rainier National Park", "WA", 1899 },
                    { 5, "North Cascades National Park", "WA", 1968 },
                    { 6, "Olympic National Park", "WA", 1938 },
                    { 7, "Death Valley National Park ", "CA", 1994 },
                    { 8, "Channel Islands National Park", "CA", 1980 },
                    { 9, "Joshua Tree National Park", "CA", 1994 },
                    { 10, "Pinnacles National Park", "CA", 2013 },
                    { 11, "Great Smoky Mountains National Park", "TN", 1934 },
                    { 12, "Kenai Fjords National Park", "AK", 1980 },
                    { 13, "Mesa Verde National Park", "CO", 1906 },
                    { 14, "Rocky Mountain National Park ", "CO", 1915 },
                    { 15, "Glacier National Park", "MT", 1910 },
                    { 16, "Yellowstone National Park", "WY", 1872 },
                    { 17, "Big Bend National Park", "TX", 1944 },
                    { 18, "Guadalupe Mountains National Park ", "TX", 1972 },
                    { 19, "Hawaii Volcanoes National Park", "HI", 1916 },
                    { 20, "Denali National Park", "AK", 1917 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NationalParks",
                keyColumn: "NationalParkId",
                keyValue: 20);
        }
    }
}
