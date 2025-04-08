using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Airlines.DataContext.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeatsCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airplanes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Continents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContinentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Continents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FlightStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fligts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightDuration = table.Column<int>(type: "int", nullable: false),
                    FlightDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PassengersCount = table.Column<int>(type: "int", nullable: false),
                    AirplaneId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fligts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fligts_Airplanes_AirplaneId",
                        column: x => x.AirplaneId,
                        principalTable: "Airplanes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContinentId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Continents_ContinentId",
                        column: x => x.ContinentId,
                        principalTable: "Continents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Crews_Fligts_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Fligts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Crews_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightStatusChanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    FlightStatusId = table.Column<int>(type: "int", nullable: false),
                    ChangedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightStatusChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FlightStatusChanges_FlightStatuses_FlightStatusId",
                        column: x => x.FlightStatusId,
                        principalTable: "FlightStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightStatusChanges_Fligts_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Fligts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Passengers_Fligts_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Fligts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TicketPrice = table.Column<decimal>(type: "decimal(9,2)", precision: 9, scale: 2, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SeatNumber = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Fligts_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Fligts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    AirplaneId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeletedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Airports_Airplanes_AirplaneId",
                        column: x => x.AirplaneId,
                        principalTable: "Airplanes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Airports_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Airports_AirplaneId",
                table: "Airports",
                column: "AirplaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Airports_CityId",
                table: "Airports",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ContinentId",
                table: "Countries",
                column: "ContinentId");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_FlightId",
                table: "Crews",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Crews_RoleId",
                table: "Crews",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightStatusChanges_FlightId",
                table: "FlightStatusChanges",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_FlightStatusChanges_FlightStatusId",
                table: "FlightStatusChanges",
                column: "FlightStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Fligts_AirplaneId",
                table: "Fligts",
                column: "AirplaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_FlightId",
                table: "Passengers",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FlightId",
                table: "Tickets",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_PassengerId",
                table: "Tickets",
                column: "PassengerId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "FlightStatusChanges");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "FlightStatuses");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Fligts");

            migrationBuilder.DropTable(
                name: "Continents");

            migrationBuilder.DropTable(
                name: "Airplanes");
        }
    }
}
