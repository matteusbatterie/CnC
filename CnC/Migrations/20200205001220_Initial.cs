using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CNC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cnc");

            migrationBuilder.CreateTable(
                name: "Artist",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Biografy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    BoxOffice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    ArtistId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movie_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalSchema: "cnc",
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OnGoing = table.Column<bool>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    FinalDate = table.Column<DateTime>(nullable: false),
                    ArtistId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Serie_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalSchema: "cnc",
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Actor",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: true),
                    SerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actor_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalSchema: "cnc",
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Actor_Movie_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "cnc",
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Actor_Serie_SerieId",
                        column: x => x.SerieId,
                        principalSchema: "cnc",
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: true),
                    SerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Director_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalSchema: "cnc",
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Director_Movie_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "cnc",
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Director_Serie_SerieId",
                        column: x => x.SerieId,
                        principalSchema: "cnc",
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: true),
                    SerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genre_Movie_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "cnc",
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Genre_Serie_SerieId",
                        column: x => x.SerieId,
                        principalSchema: "cnc",
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    MovieId = table.Column<int>(nullable: true),
                    SerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Language_Movie_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "cnc",
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Language_Serie_SerieId",
                        column: x => x.SerieId,
                        principalSchema: "cnc",
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Music",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Explicit = table.Column<bool>(nullable: false),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    ArtistId = table.Column<int>(nullable: true),
                    MovieId = table.Column<int>(nullable: true),
                    SerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Music_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalSchema: "cnc",
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Music_Movie_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "cnc",
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Music_Serie_SerieId",
                        column: x => x.SerieId,
                        principalSchema: "cnc",
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Producer",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(nullable: false),
                    MovieId = table.Column<int>(nullable: true),
                    SerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producer_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalSchema: "cnc",
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Producer_Movie_MovieId",
                        column: x => x.MovieId,
                        principalSchema: "cnc",
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producer_Serie_SerieId",
                        column: x => x.SerieId,
                        principalSchema: "cnc",
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Season",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SerieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Season_Serie_SerieId",
                        column: x => x.SerieId,
                        principalSchema: "cnc",
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(nullable: false),
                    MusicId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Author_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalSchema: "cnc",
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Author_Music_MusicId",
                        column: x => x.MusicId,
                        principalSchema: "cnc",
                        principalTable: "Music",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lyric",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(nullable: true),
                    MusicId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lyric", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lyric_Music_MusicId",
                        column: x => x.MusicId,
                        principalSchema: "cnc",
                        principalTable: "Music",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Episode",
                schema: "cnc",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SerieId = table.Column<int>(nullable: false),
                    SeasonId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episode_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalSchema: "cnc",
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Episode_Serie_SerieId",
                        column: x => x.SerieId,
                        principalSchema: "cnc",
                        principalTable: "Serie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actor_ArtistId",
                schema: "cnc",
                table: "Actor",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_MovieId",
                schema: "cnc",
                table: "Actor",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_SerieId",
                schema: "cnc",
                table: "Actor",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_ArtistId",
                schema: "cnc",
                table: "Author",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_MusicId",
                schema: "cnc",
                table: "Author",
                column: "MusicId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_ArtistId",
                schema: "cnc",
                table: "Director",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_MovieId",
                schema: "cnc",
                table: "Director",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_SerieId",
                schema: "cnc",
                table: "Director",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Episode_SeasonId",
                schema: "cnc",
                table: "Episode",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Episode_SerieId",
                schema: "cnc",
                table: "Episode",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_MovieId",
                schema: "cnc",
                table: "Genre",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_SerieId",
                schema: "cnc",
                table: "Genre",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_MovieId",
                schema: "cnc",
                table: "Language",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Language_SerieId",
                schema: "cnc",
                table: "Language",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Lyric_MusicId",
                schema: "cnc",
                table: "Lyric",
                column: "MusicId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ArtistId",
                schema: "cnc",
                table: "Movie",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Music_ArtistId",
                schema: "cnc",
                table: "Music",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Music_MovieId",
                schema: "cnc",
                table: "Music",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Music_SerieId",
                schema: "cnc",
                table: "Music",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Producer_ArtistId",
                schema: "cnc",
                table: "Producer",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Producer_MovieId",
                schema: "cnc",
                table: "Producer",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Producer_SerieId",
                schema: "cnc",
                table: "Producer",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Season_SerieId",
                schema: "cnc",
                table: "Season",
                column: "SerieId");

            migrationBuilder.CreateIndex(
                name: "IX_Serie_ArtistId",
                schema: "cnc",
                table: "Serie",
                column: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actor",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Author",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Director",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Episode",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Genre",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Lyric",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Producer",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Season",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Music",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Movie",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Serie",
                schema: "cnc");

            migrationBuilder.DropTable(
                name: "Artist",
                schema: "cnc");
        }
    }
}
