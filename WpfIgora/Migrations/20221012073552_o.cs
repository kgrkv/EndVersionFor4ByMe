using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WpfIgora.Migrations
{
    public partial class o : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fatername",
                table: "Users",
                newName: "Fathername");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Databirth",
                table: "Users",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fathername",
                table: "Users",
                newName: "Fatername");

            migrationBuilder.AlterColumn<string>(
                name: "Databirth",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
