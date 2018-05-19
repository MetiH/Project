using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoffeeShop.Migrations
{
    public partial class FeedbackAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Coffees",
                table: "Coffees");

            migrationBuilder.RenameTable(
                name: "Coffees",
                newName: "coffees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_coffees",
                table: "coffees",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_coffees",
                table: "coffees");

            migrationBuilder.RenameTable(
                name: "coffees",
                newName: "Coffees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coffees",
                table: "Coffees",
                column: "Id");
        }
    }
}
