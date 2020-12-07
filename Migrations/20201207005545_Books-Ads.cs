using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondHandBook.Migrations
{
    public partial class BooksAds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookADs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    College = table.Column<string>(nullable: false),
                    Rate = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookADs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookADs");
        }
    }
}
