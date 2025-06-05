using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalPortfolioWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AddExperienceForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Projects",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ExperienceId",
                table: "Projects",
                column: "ExperienceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Experiences_ExperienceId",
                table: "Projects",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Experiences_ExperienceId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ExperienceId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Projects");
        }
    }
}
