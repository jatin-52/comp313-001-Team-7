using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecondHandBook.Migrations
{
    public partial class UserIdFiledAddedInBookAdsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "bookADs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "bookADs");
        }
    }
}
