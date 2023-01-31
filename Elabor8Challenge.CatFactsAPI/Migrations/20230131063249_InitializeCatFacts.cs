using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

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
                name: "CatFacts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    Used = table.Column<bool>(type: "INTEGER", nullable: false),
                    Deleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    Upvotes = table.Column<int>(type: "INTEGER", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    V = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatFacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatFacts_FactStatuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "FactStatuses",
                        principalColumn: "Id");
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
                name: "CatFactUser",
                columns: table => new
                {
                    UpvotedCatFactsId = table.Column<string>(type: "TEXT", nullable: false),
                    UserUpvotedId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatFactUser", x => new { x.UpvotedCatFactsId, x.UserUpvotedId });
                    table.ForeignKey(
                        name: "FK_CatFactUser_CatFacts_UpvotedCatFactsId",
                        column: x => x.UpvotedCatFactsId,
                        principalTable: "CatFacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatFactUser_Users_UserUpvotedId",
                        column: x => x.UserUpvotedId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatFacts_StatusId",
                table: "CatFacts",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CatFactUser_UserUpvotedId",
                table: "CatFactUser",
                column: "UserUpvotedId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_NameId",
                table: "Users",
                column: "NameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatFactUser");

            migrationBuilder.DropTable(
                name: "CatFacts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "FactStatuses");

            migrationBuilder.DropTable(
                name: "Names");
        }
    }
}
