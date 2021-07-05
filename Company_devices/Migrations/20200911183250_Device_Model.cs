using Microsoft.EntityFrameworkCore.Migrations;

namespace Company_devices.Migrations
{
    public partial class Device_Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    Empid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 60, nullable: false),
                    LastName = table.Column<string>(maxLength: 60, nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    IdNumber = table.Column<long>(nullable: true),
                    Ethnicity = table.Column<string>(maxLength: 20, nullable: true),
                    Position = table.Column<string>(nullable: true),
                    AlternativeContact = table.Column<string>(nullable: true),
                    Address = table.Column<string>(maxLength: 25, nullable: true),
                    StreetName = table.Column<string>(maxLength: 25, nullable: true),
                    Surburb = table.Column<string>(nullable: true),
                    City = table.Column<string>(maxLength: 60, nullable: true),
                    PostalCode = table.Column<int>(nullable: true),
                    Province = table.Column<string>(maxLength: 40, nullable: true),
                    id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.Empid);
                    table.ForeignKey(
                        name: "FK_employees_Companies_id",
                        column: x => x.id,
                        principalTable: "Companies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_employees_id",
                table: "employees",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
