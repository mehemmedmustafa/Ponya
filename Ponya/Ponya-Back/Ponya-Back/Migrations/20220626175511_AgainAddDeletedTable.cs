﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Ponya_Back.Migrations
{
    public partial class AgainAddDeletedTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OurTeams",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OurTeams");
        }
    }
}
