using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbsenSiswaSMK8Web.Migrations
{
    /// <inheritdoc />
    public partial class dataSiswa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataSiswa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NIS = table.Column<int>(type: "int", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempatLahir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TanggalLahir = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataSiswa", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataSiswa");
        }
    }
}
