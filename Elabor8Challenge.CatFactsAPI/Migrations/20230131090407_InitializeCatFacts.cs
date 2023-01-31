using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Elabor8Challenge.CatFactsAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitializeCatFacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FactStatuses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Verified = table.Column<bool>(type: "INTEGER", nullable: false),
                    SentCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Names",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    First = table.Column<string>(type: "TEXT", nullable: true),
                    Last = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Names", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    NameId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Names_NameId",
                        column: x => x.NameId,
                        principalTable: "Names",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CatFacts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    Used = table.Column<bool>(type: "INTEGER", nullable: false),
                    Deleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Source = table.Column<int>(type: "INTEGER", nullable: false),
                    Upvotes = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    V = table.Column<int>(type: "INTEGER", nullable: false),
                    UserUpvoted = table.Column<string>(type: "TEXT", nullable: true),
                    StatusId = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatFacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatFacts_FactStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "FactStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CatFacts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "FactStatuses",
                columns: new[] { "Id", "SentCount", "Verified" },
                values: new object[,]
                {
                    { "58e007480aac31001185ecea", 7, true },
                    { "58e007480aac31001185eceb", 1, true },
                    { "58e007480aac31001185ecef", 2, false }
                });

            migrationBuilder.InsertData(
                table: "Names",
                columns: new[] { "Id", "First", "Last" },
                values: new object[,]
                {
                    { "58e007480aac31001185ecea", "Liz", "Wilson" },
                    { "58e007480aac31001185ecef", "Jon", "Arbuckle" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "NameId" },
                values: new object[,]
                {
                    { "58e007480aac31001185ecea", "58e007480aac31001185ecea" },
                    { "58e007480aac31001185ecef", "58e007480aac31001185ecef" }
                });

            migrationBuilder.InsertData(
                table: "CatFacts",
                columns: new[] { "Id", "CreatedAt", "Deleted", "Source", "StatusId", "Text", "Type", "UpdatedAt", "Upvotes", "Used", "UserId", "UserUpvoted", "V" },
                values: new object[,]
                {
                    { "58e007480aac31001185ecea", new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106), false, 0, "58e007480aac31001185ecea", "By the time a cat is 9 years old, it will only have been awake for three years of its life.", 0, new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106), 6, true, "58e007480aac31001185ecef", null, 2 },
                    { "58e007480aac31001185eceb", new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106), false, 0, "58e007480aac31001185eceb", "Cats love lasagna and hate mondays.", 0, new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106), 19, true, "58e007480aac31001185ecea", null, 2 },
                    { "58e007480aac31001185ecef", new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106), false, 0, "58e007480aac31001185ecef", "The frequency of a domestic cat's purr is the same at which muscles and bones repair themselves.", 0, new DateTime(2023, 1, 31, 19, 4, 7, 867, DateTimeKind.Local).AddTicks(5106), 12, true, "58e007480aac31001185ecef", null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatFacts_StatusId",
                table: "CatFacts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CatFacts_UserId",
                table: "CatFacts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NameId",
                table: "Users",
                column: "NameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatFacts");

            migrationBuilder.DropTable(
                name: "FactStatuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Names");
        }
    }
}
