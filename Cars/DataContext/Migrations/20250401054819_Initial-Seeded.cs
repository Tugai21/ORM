using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataContext.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricePerLeter = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Length = table.Column<double>(type: "float", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Width = table.Column<double>(type: "float", nullable: false),
                    Consumption = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HorsePower = table.Column<double>(type: "float", nullable: false),
                    Torque = table.Column<double>(type: "float", nullable: false),
                    CylinderCount = table.Column<int>(type: "int", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engines_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ModelEngines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelEngines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModelEngines_Engines_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ModelEngines_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "BMW" },
                    { 2, "Audi" },
                    { 3, "Peugeot" }
                });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name", "PricePerLeter" },
                values: new object[,]
                {
                    { 1, "Gasoline", 1.0 },
                    { 2, "Diesel", 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Engines",
                columns: new[] { "Id", "CylinderCount", "FuelId", "HorsePower", "Name", "Torque" },
                values: new object[,]
                {
                    { 1, 6, 1, 431.0, "3.0", 850.0 },
                    { 2, 4, 2, 163.0, "2.0 TDI ultra", 380.0 },
                    { 3, 4, 2, 150.0, "2.0 BlueHDi", 370.0 }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CarId", "Consumption", "Height", "Length", "Name", "Width", "Year" },
                values: new object[,]
                {
                    { 1, 1, 8.8000000000000007, 1.5, 4.5, "M3", 2.0, 2014 },
                    { 2, 2, 4.2000000000000002, 1.3999999999999999, 4.2999999999999998, "A4", 1.8999999999999999, 2014 },
                    { 3, 3, 4.0, 1.6000000000000001, 4.7000000000000002, "508", 2.1000000000000001, 2014 }
                });

            migrationBuilder.InsertData(
                table: "ModelEngines",
                columns: new[] { "Id", "EngineId", "ModelId", "Name" },
                values: new object[,]
                {
                    { 1, 1, 1, "M3 3.0" },
                    { 2, 2, 2, "A4 2.0 TDI ultra" },
                    { 3, 3, 3, "508 2.0 BlueHDi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Engines_FuelId",
                table: "Engines",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelEngines_EngineId",
                table: "ModelEngines",
                column: "EngineId");

            migrationBuilder.CreateIndex(
                name: "IX_ModelEngines_ModelId",
                table: "ModelEngines",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_CarId",
                table: "Models",
                column: "CarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModelEngines");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
