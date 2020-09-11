using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LS.Core.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CLASS",
                columns: table => new
                {
                    GUID = table.Column<string>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    CLASSNAME = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLASS", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "STUDENT",
                columns: table => new
                {
                    GUID = table.Column<string>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    STUNAME = table.Column<string>(nullable: true),
                    STUSEX = table.Column<string>(nullable: true),
                    STUAGE = table.Column<int>(nullable: false),
                    STUCLASS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STUDENT", x => x.GUID);
                });

            migrationBuilder.CreateTable(
                name: "TEACHER",
                columns: table => new
                {
                    GUID = table.Column<string>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    TEACHERNAME = table.Column<string>(nullable: true),
                    CLASSID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEACHER", x => x.GUID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLASS");

            migrationBuilder.DropTable(
                name: "STUDENT");

            migrationBuilder.DropTable(
                name: "TEACHER");
        }
    }
}
