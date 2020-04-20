using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefsAndDishes.Migrations
{
    public partial class newMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_CreatorChefID",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_CreatorChefID",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "CreatorChefID",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "ChefID",
                table: "Dishes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_ChefID",
                table: "Dishes",
                column: "ChefID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_ChefID",
                table: "Dishes",
                column: "ChefID",
                principalTable: "Chefs",
                principalColumn: "ChefID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_ChefID",
                table: "Dishes");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_ChefID",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "ChefID",
                table: "Dishes");

            migrationBuilder.AddColumn<int>(
                name: "CreatorChefID",
                table: "Dishes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_CreatorChefID",
                table: "Dishes",
                column: "CreatorChefID");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_CreatorChefID",
                table: "Dishes",
                column: "CreatorChefID",
                principalTable: "Chefs",
                principalColumn: "ChefID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
