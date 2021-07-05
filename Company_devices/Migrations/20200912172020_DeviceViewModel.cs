using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company_devices.Migrations
{
    public partial class DeviceViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "devices",
                columns: table => new
                {
                    deviceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    macD = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false),
                    Vendor = table.Column<string>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    majorId = table.Column<int>(nullable: false),
                    minorId = table.Column<int>(nullable: false),
                    date_create = table.Column<DateTime>(nullable: false),
                    Empid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devices", x => x.deviceID);
                    table.ForeignKey(
                        name: "FK_devices_employees_Empid",
                        column: x => x.Empid,
                        principalTable: "employees",
                        principalColumn: "Empid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_devices_Empid",
                table: "devices",
                column: "Empid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "devices");
        }
    }
}
