using Microsoft.EntityFrameworkCore.Migrations;

namespace CNC.Migrations
{
    public partial class ArtistRelationshipUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Artist_ArtistId",
                schema: "cnc",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Movie_MovieId",
                schema: "cnc",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_Actor_Serie_SerieId",
                schema: "cnc",
                table: "Actor");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_Artist_ArtistId",
                schema: "cnc",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Author_Music_MusicId",
                schema: "cnc",
                table: "Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Director_Artist_ArtistId",
                schema: "cnc",
                table: "Director");

            migrationBuilder.DropForeignKey(
                name: "FK_Director_Movie_MovieId",
                schema: "cnc",
                table: "Director");

            migrationBuilder.DropForeignKey(
                name: "FK_Director_Serie_SerieId",
                schema: "cnc",
                table: "Director");

            migrationBuilder.DropForeignKey(
                name: "FK_Episode_Season_SeasonId",
                schema: "cnc",
                table: "Episode");

            migrationBuilder.DropForeignKey(
                name: "FK_Episode_Serie_SerieId",
                schema: "cnc",
                table: "Episode");

            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Movie_MovieId",
                schema: "cnc",
                table: "Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Genre_Serie_SerieId",
                schema: "cnc",
                table: "Genre");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_Movie_MovieId",
                schema: "cnc",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Language_Serie_SerieId",
                schema: "cnc",
                table: "Language");

            migrationBuilder.DropForeignKey(
                name: "FK_Lyric_Music_MusicId",
                schema: "cnc",
                table: "Lyric");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Artist_ArtistId",
                schema: "cnc",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Artist_ArtistId",
                schema: "cnc",
                table: "Music");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Movie_MovieId",
                schema: "cnc",
                table: "Music");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Serie_SerieId",
                schema: "cnc",
                table: "Music");

            migrationBuilder.DropForeignKey(
                name: "FK_Producer_Artist_ArtistId",
                schema: "cnc",
                table: "Producer");

            migrationBuilder.DropForeignKey(
                name: "FK_Producer_Movie_MovieId",
                schema: "cnc",
                table: "Producer");

            migrationBuilder.DropForeignKey(
                name: "FK_Producer_Serie_SerieId",
                schema: "cnc",
                table: "Producer");

            migrationBuilder.DropForeignKey(
                name: "FK_Season_Serie_SerieId",
                schema: "cnc",
                table: "Season");

            migrationBuilder.DropForeignKey(
                name: "FK_Serie_Artist_ArtistId",
                schema: "cnc",
                table: "Serie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Serie",
                schema: "cnc",
                table: "Serie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Season",
                schema: "cnc",
                table: "Season");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producer",
                schema: "cnc",
                table: "Producer");

            migrationBuilder.DropIndex(
                name: "IX_Producer_MovieId",
                schema: "cnc",
                table: "Producer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                schema: "cnc",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lyric",
                schema: "cnc",
                table: "Lyric");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                schema: "cnc",
                table: "Language");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                schema: "cnc",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Episode",
                schema: "cnc",
                table: "Episode");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                schema: "cnc",
                table: "Director");

            migrationBuilder.DropIndex(
                name: "IX_Director_MovieId",
                schema: "cnc",
                table: "Director");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                schema: "cnc",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_MusicId",
                schema: "cnc",
                table: "Author");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artist",
                schema: "cnc",
                table: "Artist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actor",
                schema: "cnc",
                table: "Actor");

            migrationBuilder.DropIndex(
                name: "IX_Actor_MovieId",
                schema: "cnc",
                table: "Actor");

            migrationBuilder.DropColumn(
                name: "MovieId",
                schema: "cnc",
                table: "Producer");

            migrationBuilder.DropColumn(
                name: "MovieId",
                schema: "cnc",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "MusicId",
                schema: "cnc",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "MovieId",
                schema: "cnc",
                table: "Actor");

            migrationBuilder.RenameTable(
                name: "Serie",
                schema: "cnc",
                newName: "Series",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Season",
                schema: "cnc",
                newName: "Seasons",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Producer",
                schema: "cnc",
                newName: "Producers",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Movie",
                schema: "cnc",
                newName: "Movies",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Lyric",
                schema: "cnc",
                newName: "Lyrics",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Language",
                schema: "cnc",
                newName: "Languages",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Genre",
                schema: "cnc",
                newName: "Genres",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Episode",
                schema: "cnc",
                newName: "Episodes",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Director",
                schema: "cnc",
                newName: "Directors",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Author",
                schema: "cnc",
                newName: "Authors",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Artist",
                schema: "cnc",
                newName: "Artists",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Actor",
                schema: "cnc",
                newName: "Actors",
                newSchema: "cnc");

            migrationBuilder.RenameIndex(
                name: "IX_Serie_ArtistId",
                schema: "cnc",
                table: "Series",
                newName: "IX_Series_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Season_SerieId",
                schema: "cnc",
                table: "Seasons",
                newName: "IX_Seasons_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Producer_SerieId",
                schema: "cnc",
                table: "Producers",
                newName: "IX_Producers_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Producer_ArtistId",
                schema: "cnc",
                table: "Producers",
                newName: "IX_Producers_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_ArtistId",
                schema: "cnc",
                table: "Movies",
                newName: "IX_Movies_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Lyric_MusicId",
                schema: "cnc",
                table: "Lyrics",
                newName: "IX_Lyrics_MusicId");

            migrationBuilder.RenameIndex(
                name: "IX_Language_SerieId",
                schema: "cnc",
                table: "Languages",
                newName: "IX_Languages_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Language_MovieId",
                schema: "cnc",
                table: "Languages",
                newName: "IX_Languages_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Genre_SerieId",
                schema: "cnc",
                table: "Genres",
                newName: "IX_Genres_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Genre_MovieId",
                schema: "cnc",
                table: "Genres",
                newName: "IX_Genres_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Episode_SerieId",
                schema: "cnc",
                table: "Episodes",
                newName: "IX_Episodes_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Episode_SeasonId",
                schema: "cnc",
                table: "Episodes",
                newName: "IX_Episodes_SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_Director_SerieId",
                schema: "cnc",
                table: "Directors",
                newName: "IX_Directors_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Director_ArtistId",
                schema: "cnc",
                table: "Directors",
                newName: "IX_Directors_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Author_ArtistId",
                schema: "cnc",
                table: "Authors",
                newName: "IX_Authors_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_SerieId",
                schema: "cnc",
                table: "Actors",
                newName: "IX_Actors_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Actor_ArtistId",
                schema: "cnc",
                table: "Actors",
                newName: "IX_Actors_ArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Series",
                schema: "cnc",
                table: "Series",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seasons",
                schema: "cnc",
                table: "Seasons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                schema: "cnc",
                table: "Producers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                schema: "cnc",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lyrics",
                schema: "cnc",
                table: "Lyrics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                schema: "cnc",
                table: "Languages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                schema: "cnc",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Episodes",
                schema: "cnc",
                table: "Episodes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                schema: "cnc",
                table: "Directors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Authors",
                schema: "cnc",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artists",
                schema: "cnc",
                table: "Artists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actors",
                schema: "cnc",
                table: "Actors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Artists_ArtistId",
                schema: "cnc",
                table: "Actors",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Series_SerieId",
                schema: "cnc",
                table: "Actors",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Artists_ArtistId",
                schema: "cnc",
                table: "Authors",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Artists_ArtistId",
                schema: "cnc",
                table: "Directors",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Directors_Series_SerieId",
                schema: "cnc",
                table: "Directors",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Seasons_SeasonId",
                schema: "cnc",
                table: "Episodes",
                column: "SeasonId",
                principalSchema: "cnc",
                principalTable: "Seasons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episodes_Series_SerieId",
                schema: "cnc",
                table: "Episodes",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Movies_MovieId",
                schema: "cnc",
                table: "Genres",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_Series_SerieId",
                schema: "cnc",
                table: "Genres",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Movies_MovieId",
                schema: "cnc",
                table: "Languages",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Series_SerieId",
                schema: "cnc",
                table: "Languages",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lyrics_Music_MusicId",
                schema: "cnc",
                table: "Lyrics",
                column: "MusicId",
                principalSchema: "cnc",
                principalTable: "Music",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Artists_ArtistId",
                schema: "cnc",
                table: "Movies",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Artists_ArtistId",
                schema: "cnc",
                table: "Music",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Movies_MovieId",
                schema: "cnc",
                table: "Music",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Series_SerieId",
                schema: "cnc",
                table: "Music",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producers_Artists_ArtistId",
                schema: "cnc",
                table: "Producers",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producers_Series_SerieId",
                schema: "cnc",
                table: "Producers",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Seasons_Series_SerieId",
                schema: "cnc",
                table: "Seasons",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Artists_ArtistId",
                schema: "cnc",
                table: "Series",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Artists_ArtistId",
                schema: "cnc",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Series_SerieId",
                schema: "cnc",
                table: "Actors");

            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Artists_ArtistId",
                schema: "cnc",
                table: "Authors");

            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Artists_ArtistId",
                schema: "cnc",
                table: "Directors");

            migrationBuilder.DropForeignKey(
                name: "FK_Directors_Series_SerieId",
                schema: "cnc",
                table: "Directors");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Seasons_SeasonId",
                schema: "cnc",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Episodes_Series_SerieId",
                schema: "cnc",
                table: "Episodes");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Movies_MovieId",
                schema: "cnc",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_Series_SerieId",
                schema: "cnc",
                table: "Genres");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Movies_MovieId",
                schema: "cnc",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Series_SerieId",
                schema: "cnc",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Lyrics_Music_MusicId",
                schema: "cnc",
                table: "Lyrics");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Artists_ArtistId",
                schema: "cnc",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Artists_ArtistId",
                schema: "cnc",
                table: "Music");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Movies_MovieId",
                schema: "cnc",
                table: "Music");

            migrationBuilder.DropForeignKey(
                name: "FK_Music_Series_SerieId",
                schema: "cnc",
                table: "Music");

            migrationBuilder.DropForeignKey(
                name: "FK_Producers_Artists_ArtistId",
                schema: "cnc",
                table: "Producers");

            migrationBuilder.DropForeignKey(
                name: "FK_Producers_Series_SerieId",
                schema: "cnc",
                table: "Producers");

            migrationBuilder.DropForeignKey(
                name: "FK_Seasons_Series_SerieId",
                schema: "cnc",
                table: "Seasons");

            migrationBuilder.DropForeignKey(
                name: "FK_Series_Artists_ArtistId",
                schema: "cnc",
                table: "Series");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Series",
                schema: "cnc",
                table: "Series");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seasons",
                schema: "cnc",
                table: "Seasons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                schema: "cnc",
                table: "Producers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                schema: "cnc",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lyrics",
                schema: "cnc",
                table: "Lyrics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                schema: "cnc",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                schema: "cnc",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Episodes",
                schema: "cnc",
                table: "Episodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                schema: "cnc",
                table: "Directors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Authors",
                schema: "cnc",
                table: "Authors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artists",
                schema: "cnc",
                table: "Artists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Actors",
                schema: "cnc",
                table: "Actors");

            migrationBuilder.RenameTable(
                name: "Series",
                schema: "cnc",
                newName: "Serie",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Seasons",
                schema: "cnc",
                newName: "Season",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Producers",
                schema: "cnc",
                newName: "Producer",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Movies",
                schema: "cnc",
                newName: "Movie",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Lyrics",
                schema: "cnc",
                newName: "Lyric",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Languages",
                schema: "cnc",
                newName: "Language",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Genres",
                schema: "cnc",
                newName: "Genre",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Episodes",
                schema: "cnc",
                newName: "Episode",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Directors",
                schema: "cnc",
                newName: "Director",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Authors",
                schema: "cnc",
                newName: "Author",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Artists",
                schema: "cnc",
                newName: "Artist",
                newSchema: "cnc");

            migrationBuilder.RenameTable(
                name: "Actors",
                schema: "cnc",
                newName: "Actor",
                newSchema: "cnc");

            migrationBuilder.RenameIndex(
                name: "IX_Series_ArtistId",
                schema: "cnc",
                table: "Serie",
                newName: "IX_Serie_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Seasons_SerieId",
                schema: "cnc",
                table: "Season",
                newName: "IX_Season_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Producers_SerieId",
                schema: "cnc",
                table: "Producer",
                newName: "IX_Producer_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Producers_ArtistId",
                schema: "cnc",
                table: "Producer",
                newName: "IX_Producer_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ArtistId",
                schema: "cnc",
                table: "Movie",
                newName: "IX_Movie_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Lyrics_MusicId",
                schema: "cnc",
                table: "Lyric",
                newName: "IX_Lyric_MusicId");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_SerieId",
                schema: "cnc",
                table: "Language",
                newName: "IX_Language_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_MovieId",
                schema: "cnc",
                table: "Language",
                newName: "IX_Language_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_SerieId",
                schema: "cnc",
                table: "Genre",
                newName: "IX_Genre_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Genres_MovieId",
                schema: "cnc",
                table: "Genre",
                newName: "IX_Genre_MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_SerieId",
                schema: "cnc",
                table: "Episode",
                newName: "IX_Episode_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Episodes_SeasonId",
                schema: "cnc",
                table: "Episode",
                newName: "IX_Episode_SeasonId");

            migrationBuilder.RenameIndex(
                name: "IX_Directors_SerieId",
                schema: "cnc",
                table: "Director",
                newName: "IX_Director_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Directors_ArtistId",
                schema: "cnc",
                table: "Director",
                newName: "IX_Director_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Authors_ArtistId",
                schema: "cnc",
                table: "Author",
                newName: "IX_Author_ArtistId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_SerieId",
                schema: "cnc",
                table: "Actor",
                newName: "IX_Actor_SerieId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_ArtistId",
                schema: "cnc",
                table: "Actor",
                newName: "IX_Actor_ArtistId");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                schema: "cnc",
                table: "Producer",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                schema: "cnc",
                table: "Director",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MusicId",
                schema: "cnc",
                table: "Author",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                schema: "cnc",
                table: "Actor",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Serie",
                schema: "cnc",
                table: "Serie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Season",
                schema: "cnc",
                table: "Season",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producer",
                schema: "cnc",
                table: "Producer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                schema: "cnc",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lyric",
                schema: "cnc",
                table: "Lyric",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                schema: "cnc",
                table: "Language",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                schema: "cnc",
                table: "Genre",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Episode",
                schema: "cnc",
                table: "Episode",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                schema: "cnc",
                table: "Director",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                schema: "cnc",
                table: "Author",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artist",
                schema: "cnc",
                table: "Artist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Actor",
                schema: "cnc",
                table: "Actor",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Producer_MovieId",
                schema: "cnc",
                table: "Producer",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Director_MovieId",
                schema: "cnc",
                table: "Director",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_MusicId",
                schema: "cnc",
                table: "Author",
                column: "MusicId");

            migrationBuilder.CreateIndex(
                name: "IX_Actor_MovieId",
                schema: "cnc",
                table: "Actor",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Artist_ArtistId",
                schema: "cnc",
                table: "Actor",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Movie_MovieId",
                schema: "cnc",
                table: "Actor",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Actor_Serie_SerieId",
                schema: "cnc",
                table: "Actor",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Artist_ArtistId",
                schema: "cnc",
                table: "Author",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Music_MusicId",
                schema: "cnc",
                table: "Author",
                column: "MusicId",
                principalSchema: "cnc",
                principalTable: "Music",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Director_Artist_ArtistId",
                schema: "cnc",
                table: "Director",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Director_Movie_MovieId",
                schema: "cnc",
                table: "Director",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Director_Serie_SerieId",
                schema: "cnc",
                table: "Director",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_Season_SeasonId",
                schema: "cnc",
                table: "Episode",
                column: "SeasonId",
                principalSchema: "cnc",
                principalTable: "Season",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Episode_Serie_SerieId",
                schema: "cnc",
                table: "Episode",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Movie_MovieId",
                schema: "cnc",
                table: "Genre",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genre_Serie_SerieId",
                schema: "cnc",
                table: "Genre",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_Movie_MovieId",
                schema: "cnc",
                table: "Language",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Language_Serie_SerieId",
                schema: "cnc",
                table: "Language",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Lyric_Music_MusicId",
                schema: "cnc",
                table: "Lyric",
                column: "MusicId",
                principalSchema: "cnc",
                principalTable: "Music",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Artist_ArtistId",
                schema: "cnc",
                table: "Movie",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Artist_ArtistId",
                schema: "cnc",
                table: "Music",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Movie_MovieId",
                schema: "cnc",
                table: "Music",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Music_Serie_SerieId",
                schema: "cnc",
                table: "Music",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producer_Artist_ArtistId",
                schema: "cnc",
                table: "Producer",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Producer_Movie_MovieId",
                schema: "cnc",
                table: "Producer",
                column: "MovieId",
                principalSchema: "cnc",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Producer_Serie_SerieId",
                schema: "cnc",
                table: "Producer",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Season_Serie_SerieId",
                schema: "cnc",
                table: "Season",
                column: "SerieId",
                principalSchema: "cnc",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Serie_Artist_ArtistId",
                schema: "cnc",
                table: "Serie",
                column: "ArtistId",
                principalSchema: "cnc",
                principalTable: "Artist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
