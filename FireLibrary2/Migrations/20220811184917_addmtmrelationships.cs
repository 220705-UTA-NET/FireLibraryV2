using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FireLibrary2.Migrations
{
    public partial class addmtmrelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookOrder",
                columns: table => new
                {
                    BooksIsbn = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OrdersOrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOrder", x => new { x.BooksIsbn, x.OrdersOrderId });
                    table.ForeignKey(
                        name: "FK_BookOrder_Books_BooksIsbn",
                        column: x => x.BooksIsbn,
                        principalTable: "Books",
                        principalColumn: "Isbn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookOrder_Orders_OrdersOrderId",
                        column: x => x.OrdersOrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrder_OrdersOrderId",
                table: "BookOrder",
                column: "OrdersOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "BookOrder");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");
        }
    }
}
