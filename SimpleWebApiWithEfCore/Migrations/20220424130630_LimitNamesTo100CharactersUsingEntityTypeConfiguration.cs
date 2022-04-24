using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleWebApiWithEfCore.Migrations
{
    public partial class LimitNamesTo100CharactersUsingEntityTypeConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Persons",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Persons",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }
    }
}
