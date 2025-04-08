using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airlines.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Continents",
                keyColumn: "Id",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Continents",
                columns: new[] { "Id", "ContinentName", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Europe", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 847, DateTimeKind.Unspecified).AddTicks(8195), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 2, "Asia", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 847, DateTimeKind.Unspecified).AddTicks(9167), new TimeSpan(0, 0, 0, 0, 0)), null, null }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ContinentId", "CountryName", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, "Bulgaria", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(1598), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 2, 1, "Romania", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(2877), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 3, 1, "France", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(2882), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 4, 1, "Italy", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(2886), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 5, 1, "Spain", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(2890), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 6, 2, "Japan", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(2907), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 7, 2, "China", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(2911), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 8, 2, "Malaysia", new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(2915), new TimeSpan(0, 0, 0, 0, 0)), null, null }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName", "CountryId", "CreatedAt", "DeletedAt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Sofia", 1, new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(5104), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 2, "Plovdiv", 1, new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(5234), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 3, "Bucharest", 2, new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(5238), new TimeSpan(0, 0, 0, 0, 0)), null, null },
                    { 4, "Paris", 3, new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(5241), new TimeSpan(0, 0, 0, 0, 0)), null, null }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AirplaneId", "CityId", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(6675), new TimeSpan(0, 0, 0, 0, 0)), null, "Sofia International Airport EAD", null },
                    { 2, null, 1, new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(6704), new TimeSpan(0, 0, 0, 0, 0)), null, "Plovdiv Airport", null },
                    { 3, null, 3, new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 0, 0, 0, 0)), null, "Henri Coanda International Airport", null },
                    { 4, null, 4, new DateTimeOffset(new DateTime(2025, 4, 8, 5, 45, 2, 848, DateTimeKind.Unspecified).AddTicks(6710), new TimeSpan(0, 0, 0, 0, 0)), null, "Charles de Gaulle Airport", null }
                });
        }
    }
}
