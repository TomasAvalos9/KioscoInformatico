using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KioscoInformaticoBackend.Migrations
{
    /// <inheritdoc />
    public partial class InicioSo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 6, 30, 13, 30, 10, 54, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 6, 30, 13, 30, 10, 54, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 6, 30, 13, 30, 10, 54, DateTimeKind.Local).AddTicks(9926));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 6, 23, 18, 35, 45, 379, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2025, 6, 23, 18, 35, 45, 379, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2025, 6, 23, 18, 35, 45, 379, DateTimeKind.Local).AddTicks(9464));
        }
    }
}
