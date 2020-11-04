using Microsoft.EntityFrameworkCore.Migrations;

namespace Lib.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    loc = table.Column<string>(nullable: false),
                    Customerid = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.loc);
                    table.ForeignKey(
                        name: "FK_location_Customer_Customerid",
                        column: x => x.Customerid,
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    name = table.Column<string>(nullable: false),
                    Customerid = table.Column<string>(nullable: true),
                    Locationloc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.name);
                    table.ForeignKey(
                        name: "FK_order_Customer_Customerid",
                        column: x => x.Customerid,
                        principalTable: "Customer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_order_location_Locationloc",
                        column: x => x.Locationloc,
                        principalTable: "location",
                        principalColumn: "loc",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Location = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    price = table.Column<decimal>(nullable: false),
                    Locationloc = table.Column<string>(nullable: true),
                    Locationloc1 = table.Column<string>(nullable: true),
                    Ordername = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Location);
                    table.ForeignKey(
                        name: "FK_Product_location_Locationloc",
                        column: x => x.Locationloc,
                        principalTable: "location",
                        principalColumn: "loc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_location_Locationloc1",
                        column: x => x.Locationloc1,
                        principalTable: "location",
                        principalColumn: "loc",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_order_Ordername",
                        column: x => x.Ordername,
                        principalTable: "order",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_location_Customerid",
                table: "location",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_order_Customerid",
                table: "order",
                column: "Customerid");

            migrationBuilder.CreateIndex(
                name: "IX_order_Locationloc",
                table: "order",
                column: "Locationloc");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Locationloc",
                table: "Product",
                column: "Locationloc");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Locationloc1",
                table: "Product",
                column: "Locationloc1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Ordername",
                table: "Product",
                column: "Ordername");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "location");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
