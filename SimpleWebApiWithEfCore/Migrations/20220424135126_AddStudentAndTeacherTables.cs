using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SimpleWebApiWithEfCore.Migrations
{
    public partial class AddStudentAndTeacherTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Field",
                table: "Person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Field",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");
        }
    }
}
