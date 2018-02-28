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
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ContractJsonData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandardContractChips",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ContractChipJsonData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardContractChips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandardContractEvents",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ContractEventJsonData = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardContractEvents", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "StandardContractChips");

            migrationBuilder.DropTable(
                name: "StandardContractEvents");
        }
    }
}
