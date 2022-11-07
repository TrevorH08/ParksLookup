using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "PointsOfInterest", "StateOrNational" },
                values: new object[] { 1, "Yellowstone", "Steam Boat Geyser, Old Faithful Geyser Mammoth Hotsprings", "National" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "PointsOfInterest", "StateOrNational" },
                values: new object[] { 2, "Yosemite", "Half Dome, Glacier Point, Yosemite Falls", "National" });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "PointsOfInterest", "StateOrNational" },
                values: new object[] { 3, "Hearst San Simeon", "Hearst Castle, San Simeon Pier, San Simeon Camp Grounds", "State" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);
        }
    }
}
