using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KioscoInformaticoBackend.Migrations
{
    /// <inheritdoc />
    public partial class InicioAWS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 36, 52, 424, DateTimeKind.Local).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 36, 52, 424, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 36, 52, 424, DateTimeKind.Local).AddTicks(3773));
        }
    }
}
