using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GermanLearningCompanion.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VocabularyWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    German = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Article = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Plural = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    English = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Bengali = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Example = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NextReviewAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocabularyWords", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VocabularyWords");
        }
    }
}
