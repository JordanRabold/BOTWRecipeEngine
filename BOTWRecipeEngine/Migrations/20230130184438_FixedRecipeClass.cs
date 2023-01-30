using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOTWRecipeEngine.Migrations
{
    /// <inheritdoc />
    public partial class FixedRecipeClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IngredientName",
                table: "Recipes",
                newName: "Num_Hearts");

            migrationBuilder.RenameColumn(
                name: "Hearts",
                table: "Recipes",
                newName: "Ingredient4");

            migrationBuilder.AddColumn<string>(
                name: "Ingredient1",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ingredient2",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ingredient3",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ingredient1",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Ingredient2",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Ingredient3",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "Num_Hearts",
                table: "Recipes",
                newName: "IngredientName");

            migrationBuilder.RenameColumn(
                name: "Ingredient4",
                table: "Recipes",
                newName: "Hearts");
        }
    }
}
