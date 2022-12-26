using Microsoft.EntityFrameworkCore.Migrations;

namespace CarService_Server.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllData",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    PlateNumber = table.Column<string>(nullable: true),
                    ManufactureYear = table.Column<int>(nullable: false),
                    WorkCategory = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Seriousness = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    WorkHourEstimation = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllData");
        }
    }
}
