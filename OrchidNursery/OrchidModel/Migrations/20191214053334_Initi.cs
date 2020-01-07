using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrchidModel.Migrations
{
    public partial class Initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    RegnoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(maxLength: 100, nullable: false),
                    EmpAddress = table.Column<string>(maxLength: 100, nullable: false),
                    NIC = table.Column<string>(maxLength: 50, nullable: false),
                    TelephoneNo = table.Column<string>(maxLength: 90, nullable: false),
                    password = table.Column<string>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.RegnoID);
                });

            migrationBuilder.CreateTable(
                name: "Employes",
                columns: table => new
                {
                    EmplyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    UserAddress = table.Column<string>(maxLength: 100, nullable: false),
                    UserNIC = table.Column<int>(maxLength: 25, nullable: false),
                    UserTeleNo = table.Column<int>(maxLength: 25, nullable: false),
                    UserPass = table.Column<string>(maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employes", x => x.EmplyID);
                });

            migrationBuilder.CreateTable(
                name: "OrchidNews",
                columns: table => new
                {
                    orchidID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orchidName = table.Column<string>(maxLength: 100, nullable: false),
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
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employes");

            migrationBuilder.DropTable(
                name: "OrchidNews");
        }
    }
}
