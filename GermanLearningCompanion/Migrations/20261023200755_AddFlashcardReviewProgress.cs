using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GermanLearningCompanion.Migrations
{
    /// <inheritdoc />
    public partial class AddFlashcardReviewProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CorrectStreak",
                table: "VocabularyWords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastReviewedAt",
                table: "VocabularyWords",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewCount",
                table: "VocabularyWords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectStreak",
                table: "VocabularyWords");

            migrationBuilder.DropColumn(
                name: "LastReviewedAt",
                table: "VocabularyWords");

            migrationBuilder.DropColumn(
                name: "ReviewCount",
                table: "VocabularyWords");
        }
    }
}
