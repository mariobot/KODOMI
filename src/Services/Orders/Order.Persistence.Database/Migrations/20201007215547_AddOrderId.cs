using Microsoft.EntityFrameworkCore.Migrations;

namespace Order.Persistence.Database.Migrations
{
    public partial class AddOrderId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                schema: "Order",
                table: "OrdersDetails",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                schema: "Order",
                table: "OrdersDetails");
        }
    }
}
