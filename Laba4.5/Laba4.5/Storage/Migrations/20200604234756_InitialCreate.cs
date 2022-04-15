using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Laba4._5.Storage.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCHhotel",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    iFloors = table.Column<int>(nullable: false),
                    iKolNum = table.Column<int>(nullable: false),
                    szName = table.Column<string>(nullable: false),
                    iKolSot = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCHhotel", x => x.gId);
                });

            migrationBuilder.CreateTable(
                name: "tblCHnumber",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    iRooms = table.Column<int>(nullable: false),
                    iSleep = table.Column<int>(nullable: false),
                    gHotelId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCHnumber", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblCHnumber_tblCHhotel_gHotelId",
                        column: x => x.gHotelId,
                        principalTable: "tblCHhotel",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblPersonal",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(nullable: false),
                    szLName = table.Column<string>(nullable: false),
                    szDolzhnost = table.Column<string>(nullable: false),
                    gHotelId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblPersonal", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblPersonal_tblCHhotel_gHotelId",
                        column: x => x.gHotelId,
                        principalTable: "tblCHhotel",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblNumber",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    iFloor = table.Column<int>(nullable: false),
                    iNomer = table.Column<int>(nullable: false),
                    gCHNumberId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblNumber", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblNumber_tblCHnumber_gCHNumberId",
                        column: x => x.gCHNumberId,
                        principalTable: "tblCHnumber",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tblClient",
                columns: table => new
                {
                    gId = table.Column<Guid>(nullable: false),
                    szName = table.Column<string>(maxLength: 50, nullable: false),
                    szLname = table.Column<string>(maxLength: 50, nullable: false),
                    iNights = table.Column<int>(nullable: false),
                    iNumber = table.Column<int>(nullable: false),
                    gNumberId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblClient", x => x.gId);
                    table.ForeignKey(
                        name: "FK_tblClient_tblNumber_gNumberId",
                        column: x => x.gNumberId,
                        principalTable: "tblNumber",
                        principalColumn: "gId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCHnumber_gHotelId",
                table: "tblCHnumber",
                column: "gHotelId");

            migrationBuilder.CreateIndex(
                name: "IX_tblClient_gNumberId",
                table: "tblClient",
                column: "gNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblNumber_gCHNumberId",
                table: "tblNumber",
                column: "gCHNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_tblPersonal_gHotelId",
                table: "tblPersonal",
                column: "gHotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblClient");

            migrationBuilder.DropTable(
                name: "tblPersonal");

            migrationBuilder.DropTable(
                name: "tblNumber");

            migrationBuilder.DropTable(
                name: "tblCHnumber");

            migrationBuilder.DropTable(
                name: "tblCHhotel");
        }
    }
}
