using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Migrations.OpusDb
{
    public partial class BasicTableCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Logo = table.Column<string>(nullable: true),
                    Website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    Skills = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SecurityProfile",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", nullable: true),
                    CreatedRight = table.Column<bool>(nullable: false),
                    ReaddRight = table.Column<bool>(nullable: false),
                    UpdateRight = table.Column<bool>(nullable: false),
                    DeleteRight = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecurityProfile", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "SecurityProfile");
        }
    }
}
