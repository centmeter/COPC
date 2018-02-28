using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace COPC.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:uuid-ossp", "'uuid-ossp', '', ''");

            migrationBuilder.CreateTable(
                name: "ContractChips",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    JsonData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractChips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractEvents",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    JsonData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractEvents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    JsonData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractChips");

            migrationBuilder.DropTable(
                name: "ContractEvents");

            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
