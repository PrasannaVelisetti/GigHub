using Microsoft.EntityFrameworkCore.Migrations;

namespace GigHubCore.Migrations
{
    public partial class PopulateGenres : Migration
    {
        private string[] columns = new[] { "Id", "Name" };

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Genres", columns, new object[]{1,"Jazz"});
            migrationBuilder.InsertData("Genres", columns, new object[] { 2, "Blues" });
            migrationBuilder.InsertData("Genres", columns, new object[] { 3, "Rock" });
            migrationBuilder.InsertData("Genres", columns, new object[] { 4, "Country" });
        }         

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData("Genres", "Id", 1);
            migrationBuilder.DeleteData("Genres", "Id", 2);
            migrationBuilder.DeleteData("Genres", "Id", 3);
            migrationBuilder.DeleteData("Genres", "Id", 4);
        }
    }
}
