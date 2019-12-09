using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrchidModel.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrchidNews",
                columns: table => new
                {
                    orchidID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orchidName = table.Column<string>(nullable: false),
                    category = table.Column<string>(nullable: true),
                    size = table.Column<int>(nullable: false),
                    price = table.Column<int>(nullable: false),
                    quanity = table.Column<int>(nullable: false),
                    manuDate = table.Column<DateTime>(nullable: false),
                    expTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrchidNews", x => x.orchidID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrchidNews");
        }
    }
}
