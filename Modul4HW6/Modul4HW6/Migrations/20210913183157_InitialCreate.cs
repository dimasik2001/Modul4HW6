using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW6.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<long>(type: "bigint", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "DateOfBirth", "Email", "InstagramURL", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1756, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Mozart", null },
                    { 2, new DateTime(1998, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "morgenstern@gmail.com", "www.instagram.com/morgen_shtern", "Morgenstern", "666-666" },
                    { 3, new DateTime(1972, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "eninem@gmail.com", "www.instagram.com/eminem", "Eminem", "123-231" },
                    { 4, new DateTime(1988, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "rihanna@gmail.com", "www.instagram.com/badgalrir", "Rihanna", "12-66-323" },
                    { 5, new DateTime(1971, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Dolores O'Riordan", null },
                    { 6, new DateTime(1963, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Joey Tempest", "8-800-555-35-35" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Rock" },
                    { 2, "Hip-Hop" },
                    { 3, "Classic" },
                    { 4, "Ethno" },
                    { 5, "Pop" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, 3090000000L, 1, new DateTime(1986, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Final Countdown" },
                    { 3, 3080000000L, 1, new DateTime(1994, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zombie" },
                    { 2, 3700000000L, 2, new DateTime(2013, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap God" },
                    { 4, 2670000000L, 2, new DateTime(2010, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love the Way You Lie" },
                    { 7, 1900000000L, 3, new DateTime(1791, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lacrimosa" },
                    { 5, 6080000000L, 4, new DateTime(1955, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ethnic Track" },
                    { 6, 1700000000L, 5, new DateTime(2020, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cadillac" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 2, 6, 1 },
                    { 1, 5, 3 },
                    { 4, 3, 2 },
                    { 5, 3, 4 },
                    { 6, 4, 4 },
                    { 3, 1, 7 },
                    { 7, 2, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_ArtistId",
                table: "ArtistSong",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongId",
                table: "ArtistSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSong");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
