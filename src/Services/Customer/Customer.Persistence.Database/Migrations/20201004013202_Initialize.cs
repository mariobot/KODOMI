using Microsoft.EntityFrameworkCore.Migrations;

namespace Customer.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Customer");

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "Customer",
                columns: table => new
                {
                    ClientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.InsertData(
                schema: "Customer",
                table: "Clients",
                columns: new[] { "ClientId", "Name" },
                values: new object[,]
                {
                    { 1, "Customer 1" },
                    { 73, "Customer 73" },
                    { 72, "Customer 72" },
                    { 71, "Customer 71" },
                    { 70, "Customer 70" },
                    { 69, "Customer 69" },
                    { 68, "Customer 68" },
                    { 67, "Customer 67" },
                    { 66, "Customer 66" },
                    { 65, "Customer 65" },
                    { 64, "Customer 64" },
                    { 63, "Customer 63" },
                    { 62, "Customer 62" },
                    { 61, "Customer 61" },
                    { 60, "Customer 60" },
                    { 59, "Customer 59" },
                    { 58, "Customer 58" },
                    { 57, "Customer 57" },
                    { 56, "Customer 56" },
                    { 55, "Customer 55" },
                    { 54, "Customer 54" },
                    { 53, "Customer 53" },
                    { 74, "Customer 74" },
                    { 52, "Customer 52" },
                    { 75, "Customer 75" },
                    { 77, "Customer 77" },
                    { 98, "Customer 98" },
                    { 97, "Customer 97" },
                    { 96, "Customer 96" },
                    { 95, "Customer 95" },
                    { 94, "Customer 94" },
                    { 93, "Customer 93" },
                    { 92, "Customer 92" },
                    { 91, "Customer 91" },
                    { 90, "Customer 90" },
                    { 89, "Customer 89" },
                    { 88, "Customer 88" },
                    { 87, "Customer 87" },
                    { 86, "Customer 86" },
                    { 85, "Customer 85" },
                    { 84, "Customer 84" },
                    { 83, "Customer 83" },
                    { 82, "Customer 82" },
                    { 81, "Customer 81" },
                    { 80, "Customer 80" },
                    { 79, "Customer 79" },
                    { 78, "Customer 78" },
                    { 76, "Customer 76" },
                    { 51, "Customer 51" },
                    { 50, "Customer 50" },
                    { 49, "Customer 49" },
                    { 22, "Customer 22" },
                    { 21, "Customer 21" },
                    { 20, "Customer 20" },
                    { 19, "Customer 19" },
                    { 18, "Customer 18" },
                    { 17, "Customer 17" },
                    { 16, "Customer 16" },
                    { 15, "Customer 15" },
                    { 14, "Customer 14" },
                    { 13, "Customer 13" },
                    { 12, "Customer 12" },
                    { 11, "Customer 11" },
                    { 10, "Customer 10" },
                    { 9, "Customer 9" },
                    { 8, "Customer 8" },
                    { 7, "Customer 7" },
                    { 6, "Customer 6" },
                    { 5, "Customer 5" },
                    { 4, "Customer 4" },
                    { 3, "Customer 3" },
                    { 2, "Customer 2" },
                    { 23, "Customer 23" },
                    { 24, "Customer 24" },
                    { 25, "Customer 25" },
                    { 26, "Customer 26" },
                    { 48, "Customer 48" },
                    { 47, "Customer 47" },
                    { 46, "Customer 46" },
                    { 45, "Customer 45" },
                    { 44, "Customer 44" },
                    { 43, "Customer 43" },
                    { 42, "Customer 42" },
                    { 41, "Customer 41" },
                    { 40, "Customer 40" },
                    { 39, "Customer 39" },
                    { 99, "Customer 99" },
                    { 38, "Customer 38" },
                    { 36, "Customer 36" },
                    { 35, "Customer 35" },
                    { 34, "Customer 34" },
                    { 33, "Customer 33" },
                    { 32, "Customer 32" },
                    { 31, "Customer 31" },
                    { 30, "Customer 30" },
                    { 29, "Customer 29" },
                    { 28, "Customer 28" },
                    { 27, "Customer 27" },
                    { 37, "Customer 37" },
                    { 100, "Customer 100" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientId",
                schema: "Customer",
                table: "Clients",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients",
                schema: "Customer");
        }
    }
}
