using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Branches_Branch_ID",
                table: "Seasons");

            migrationBuilder.DropIndex(
                name: "IX_Seasons_Branch_ID",
                table: "Seasons");

            migrationBuilder.DropColumn(
                name: "Branch_ID",
                table: "Seasons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Branch_ID",
                table: "Seasons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_Branch_ID",
                table: "Seasons",
                column: "Branch_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Branches_Branch_ID",
                table: "Seasons",
                column: "Branch_ID",
                principalTable: "Branches",
                principalColumn: "Branch_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
