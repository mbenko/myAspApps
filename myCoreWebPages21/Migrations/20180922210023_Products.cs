﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace myCoreWebPages21.Migrations
{
    public partial class Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Abstract = table.Column<string>(nullable: true),
                    Presenter = table.Column<string>(nullable: true),
                    Attendees = table.Column<int>(nullable: false),
                    Timeslot = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Session");
        }
    }
}
