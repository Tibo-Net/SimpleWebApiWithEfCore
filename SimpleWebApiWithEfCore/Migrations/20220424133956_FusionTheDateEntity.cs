using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleWebApiWithEfCore.Migrations
{
    public partial class FusionTheDateEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Date_DateOfBirthId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "Date");

            migrationBuilder.DropIndex(
                name: "IX_Persons_DateOfBirthId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DateOfBirthId",
                table: "Persons");

            migrationBuilder.AddColumn<int>(
                name: "DateOfBirth_Day",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DateOfBirth_Month",
                table: "Persons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DateOfBirth_Year",
                table: "Persons",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth_Day",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DateOfBirth_Month",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DateOfBirth_Year",
                table: "Persons");

            migrationBuilder.AddColumn<Guid>(
                name: "DateOfBirthId",
                table: "Persons",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Date",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_DateOfBirthId",
                table: "Persons",
                column: "DateOfBirthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Date_DateOfBirthId",
                table: "Persons",
                column: "DateOfBirthId",
                principalTable: "Date",
                principalColumn: "Id");
        }
    }
}
