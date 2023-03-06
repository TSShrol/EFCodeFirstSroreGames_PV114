using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StyleGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StyleGames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompGame",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameGame = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Studio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Release = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StyleGameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompGame_StyleGames_StyleGameId",
                        column: x => x.StyleGameId,
                        principalTable: "StyleGames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "StyleGames",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Info ArcadRaising...", "ArcadRaising" },
                    { 2, "Info Shooter...", "Shooter" },
                    { 3, "Info Raising...", "Raising" },
                    { 4, "Comand game.....", "Strategy" }
                });

            migrationBuilder.InsertData(
                table: "CompGame",
                columns: new[] { "Id", "NameGame", "Release", "Studio", "StyleGameId" },
                values: new object[,]
                {
                    { 1, "Need for Speed", new DateTime(2015, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "EAGames Sports", 1 },
                    { 4, "S.T.A.L.K.E.R 2", new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GSC", 1 },
                    { 2, "Contro Strike", new DateTime(2015, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valve", 2 },
                    { 3, "My little pony", new DateTime(2015, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valve", 2 },
                    { 5, "Heroes 3.5", new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "GSC", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompGame_StyleGameId",
                table: "CompGame",
                column: "StyleGameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompGame");

            migrationBuilder.DropTable(
                name: "StyleGames");
        }
    }
}
