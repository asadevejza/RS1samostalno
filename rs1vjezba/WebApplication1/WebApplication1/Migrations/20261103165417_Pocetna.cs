using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Pocetna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojIndeksa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateOnly>(type: "date", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Studenti",
                columns: new[] { "Id", "BrojIndeksa", "DatumKreiranja", "DatumRodjenja", "Ime", "Prezime" },
                values: new object[,]
                {
                    { 1, "IB230014", new DateTime(2026, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2004, 2, 14), "Adna", "Sunje" },
                    { 2, "IB230016", new DateTime(2026, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Asad", "Vejzovic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studenti");
        }
    }
}
