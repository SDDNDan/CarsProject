using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class AddNewCarFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Chassiss_ChassisIdF",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Engines_EngineIdF",
                table: "Cars");

            migrationBuilder.AlterColumn<Guid>(
                name: "EngineIdF",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "ChassisIdF",
                table: "Cars",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "ChassisId",
                table: "Cars",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EngineId",
                table: "Cars",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ChassisId",
                table: "Cars",
                column: "ChassisId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_EngineId",
                table: "Cars",
                column: "EngineId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Chassiss_ChassisId",
                table: "Cars",
                column: "ChassisId",
                principalTable: "Chassiss",
                principalColumn: "ChassisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Chassiss_ChassisIdF",
                table: "Cars",
                column: "ChassisIdF",
                principalTable: "Chassiss",
                principalColumn: "ChassisId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Engines_EngineId",
                table: "Cars",
                column: "EngineId",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Engines_EngineIdF",
                table: "Cars",
                column: "EngineIdF",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Chassiss_ChassisId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Chassiss_ChassisIdF",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Engines_EngineId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Engines_EngineIdF",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ChassisId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_EngineId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ChassisId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "EngineId",
                table: "Cars");

            migrationBuilder.AlterColumn<Guid>(
                name: "EngineIdF",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ChassisIdF",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Chassiss_ChassisIdF",
                table: "Cars",
                column: "ChassisIdF",
                principalTable: "Chassiss",
                principalColumn: "ChassisId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Engines_EngineIdF",
                table: "Cars",
                column: "EngineIdF",
                principalTable: "Engines",
                principalColumn: "EngineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
