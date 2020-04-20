﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace testAutoHistory.Migrations
{
    public partial class AddAutoHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RowId = table.Column<string>(maxLength: 50, nullable: false),
                    TableName = table.Column<string>(maxLength: 128, nullable: false),
                    Changed = table.Column<string>(nullable: true),
                    Kind = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoHistory", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutoHistory");
        }
    }
}
