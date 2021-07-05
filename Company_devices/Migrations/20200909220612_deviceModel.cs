using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Company_devices.Migrations
{
    public partial class deviceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: false),
                    RegistrationNO = table.Column<string>(maxLength: 12, nullable: false),
                    Director = table.Column<string>(nullable: false),
                    TelphoneNumber = table.Column<string>(maxLength: 10, nullable: false),
                    CellphoneNumber = table.Column<string>(maxLength: 10, nullable: true),
                    email = table.Column<string>(nullable: false),
                    Address = table.Column<string>(maxLength: 25, nullable: true),
                    ComplexName = table.Column<string>(nullable: true),
                    StreetName = table.Column<string>(maxLength: 25, nullable: true),
                    Surburb = table.Column<string>(nullable: true),
                    City = table.Column<string>(maxLength: 60, nullable: true),
                    PostalCode = table.Column<int>(nullable: true),
                    image = table.Column<byte[]>(nullable: true),
                    Addrees1 = table.Column<string>(nullable: true),
                    Addrees2 = table.Column<string>(nullable: true),
                    Addrees3 = table.Column<string>(nullable: true),
                    Addrees4 = table.Column<string>(nullable: true),
                    Addrees5 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
