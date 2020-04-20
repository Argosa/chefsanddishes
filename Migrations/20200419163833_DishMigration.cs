using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ChefsAndDishes.Migrations
{
    public partial class DishMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DishName = table.Column<string>(nullable: false),
                    Tastiness = table.Column<int>(nullable: false),
                    Calories = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CreatorChefID = table.Column<int>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishID);
                    table.ForeignKey(
                        name: "FK_Dishes_Chefs_CreatorChefID",
                        column: x => x.CreatorChefID,
                        principalTable: "Chefs",
                        principalColumn: "ChefID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_CreatorChefID",
                table: "Dishes",
                column: "CreatorChefID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dishes");
        }
    }
}
