using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class migration_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Products",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Customers",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Categories",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Baskets",
                newName: "UpdateTime");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "BasketItems",
                newName: "UpdateTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Products",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Customers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "Baskets",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateTime",
                table: "BasketItems",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "Baskets");

            migrationBuilder.DropColumn(
                name: "CreateTime",
                table: "BasketItems");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Products",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Customers",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Categories",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "Baskets",
                newName: "CreateDate");

            migrationBuilder.RenameColumn(
                name: "UpdateTime",
                table: "BasketItems",
                newName: "CreateDate");
        }
    }
}
