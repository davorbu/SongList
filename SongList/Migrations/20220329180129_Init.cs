using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SongList.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    SongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.SongId);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Name", "Rating", "Year" },
                values: new object[] { 1, "Master of Puppets", 5, 1980 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Name", "Rating", "Year" },
                values: new object[] { 2, "Wonderwall", 4, 1990 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "Name", "Rating", "Year" },
                values: new object[] { 3, "Lose Yourself", 1, 2005 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
