using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tinder_1.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "BadHabitsAttitudes",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadHabitsAttitudes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Favorites",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    FavoriteUserId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmGenres",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicGenres",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicGenres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Login = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: false),
                    GenderId = table.Column<Guid>(type: "uuid", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CityId = table.Column<Guid>(type: "uuid", nullable: true),
                    PhotoPath = table.Column<string>(type: "text", nullable: false),
                    HobbyId = table.Column<Guid>(type: "uuid", nullable: true),
                    MusicGenreId = table.Column<Guid>(type: "uuid", nullable: true),
                    FilmGenreId = table.Column<Guid>(type: "uuid", nullable: true),
                    BadHabitsAttitudeId = table.Column<Guid>(type: "uuid", nullable: true),
                    AboutMe = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_BadHabitsAttitudes_BadHabitsAttitudeId",
                        column: x => x.BadHabitsAttitudeId,
                        principalSchema: "public",
                        principalTable: "BadHabitsAttitudes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProfiles_Cities_CityId",
                        column: x => x.CityId,
                        principalSchema: "public",
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProfiles_FilmGenres_FilmGenreId",
                        column: x => x.FilmGenreId,
                        principalSchema: "public",
                        principalTable: "FilmGenres",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProfiles_Genders_GenderId",
                        column: x => x.GenderId,
                        principalSchema: "public",
                        principalTable: "Genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProfiles_Hobbies_HobbyId",
                        column: x => x.HobbyId,
                        principalSchema: "public",
                        principalTable: "Hobbies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProfiles_MusicGenres_MusicGenreId",
                        column: x => x.MusicGenreId,
                        principalSchema: "public",
                        principalTable: "MusicGenres",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProfiles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "public",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_BadHabitsAttitudeId",
                schema: "public",
                table: "UserProfiles",
                column: "BadHabitsAttitudeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_CityId",
                schema: "public",
                table: "UserProfiles",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_FilmGenreId",
                schema: "public",
                table: "UserProfiles",
                column: "FilmGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_GenderId",
                schema: "public",
                table: "UserProfiles",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_HobbyId",
                schema: "public",
                table: "UserProfiles",
                column: "HobbyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_MusicGenreId",
                schema: "public",
                table: "UserProfiles",
                column: "MusicGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserId",
                schema: "public",
                table: "UserProfiles",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites",
                schema: "public");

            migrationBuilder.DropTable(
                name: "UserProfiles",
                schema: "public");

            migrationBuilder.DropTable(
                name: "BadHabitsAttitudes",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "public");

            migrationBuilder.DropTable(
                name: "FilmGenres",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Genders",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Hobbies",
                schema: "public");

            migrationBuilder.DropTable(
                name: "MusicGenres",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "public");
        }
    }
}
