using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class FixAddNewCarFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Chassiss_ChassisIdF",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Engines_EngineIdF",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ChassisIdF",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_EngineIdF",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ChassisIdF",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineIdF",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ChassisIdF",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EngineIdF",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ChassisIdF",
                table: "Cars",
                column: "ChassisIdF");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EngineIdF",
                table: "Cars",
                column: "EngineIdF");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Chassiss_ChassisIdF",
                table: "Cars",
                column: "ChassisIdF",
                principalTable: "Chassiss",
                principalColumn: "ChassisId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Engines_EngineIdF",
                table: "Cars",
                column: "EngineIdF",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
