using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chassiss",
                columns: table => new
                {
                    ChassisId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CodeNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassiss", x => x.ChassisId);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    EngineId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CylindersNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.EngineId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<Guid>(nullable: false),
                    ChassisIdF = table.Column<Guid>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    EngineIdF = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                    table.ForeignKey(
                        name: "FK_Cars_Chassiss_ChassisIdF",
                        column: x => x.ChassisIdF,
                        principalTable: "Chassiss",
                        principalColumn: "ChassisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Engines_EngineIdF",
                        column: x => x.EngineIdF,
                        principalTable: "Engines",
                        principalColumn: "EngineId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarUser",
                columns: table => new
                {
                    CarId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarUser", x => new { x.CarId, x.UserId });
                    table.ForeignKey(
                        name: "FK_CarUser_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "CarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarUser_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ChassisIdF",
                table: "Cars",
                column: "ChassisIdF");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EngineIdF",
                table: "Cars",
                column: "EngineIdF");

            migrationBuilder.CreateIndex(
                name: "IX_CarUser_UserId",
                table: "CarUser",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarUser");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Chassiss");

            migrationBuilder.DropTable(
                name: "Engines");
        }
    }
}
