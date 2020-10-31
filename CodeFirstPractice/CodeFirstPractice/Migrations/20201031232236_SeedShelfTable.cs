using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstPractice.Migrations
{
    public partial class SeedShelfTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shelf",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { -1, "Work" },
                    { -2, "Computer" },
                    { -3, "Kitchen" },
                    { -4, "DiningRoom" },
                    { -5, "BedRoom" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Shelf",
                keyColumn: "ID",
                keyValue: -1);
        }
    }
}
