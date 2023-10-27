using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParkApi.Migrations
{
    public partial class StateParkSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StateParks",
                columns: new[] { "StateParkId", "Name", "StateCode", "YearCreated" },
                values: new object[,]
                {
                    { 1, "Custer State Park", "SD", 1912 },
                    { 2, "Gulf State Park", "AL", 1939 },
                    { 3, "Silver Sands State Park", "CT", 1960 },
                    { 4, "Starved Rock State Park", "IL", 1911 },
                    { 5, "Chicot State Park", "LA", 1939 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StateParks",
                keyColumn: "StateParkId",
                keyValue: 5);
        }
    }
}
