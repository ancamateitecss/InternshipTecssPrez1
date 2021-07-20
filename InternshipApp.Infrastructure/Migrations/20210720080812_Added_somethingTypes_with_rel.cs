using Microsoft.EntityFrameworkCore.Migrations;

namespace InternshipApp.Infrastructure.Migrations
{
    public partial class Added_somethingTypes_with_rel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "MusicTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MusicTypes_EventId",
                table: "MusicTypes",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_MusicTypes_Events_EventId",
                table: "MusicTypes",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MusicTypes_Events_EventId",
                table: "MusicTypes");

            migrationBuilder.DropIndex(
                name: "IX_MusicTypes_EventId",
                table: "MusicTypes");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "MusicTypes");
        }
    }
}
