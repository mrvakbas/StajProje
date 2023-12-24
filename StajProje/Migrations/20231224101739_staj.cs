using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StajProje.Migrations
{
    public partial class staj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RickResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Episode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Characters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RickResults", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "RickResults",
                columns: new[] { "Id", "AirDate", "Characters", "Created", "Episode", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "December 2, 2013", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:33.798Z", "S01E01", "Pilot", "https://rickandmortyapi.com/api/episode/1" },
                    { 2, "December 9, 2013", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:33.916Z", "S01E02", "Lawnmower Dog", "https://rickandmortyapi.com/api/episode/2" },
                    { 3, "December 16, 2013", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.022Z", "S01E03", "Anatomy Park", "https://rickandmortyapi.com/api/episode/3" },
                    { 4, "January 13, 2014", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.129Z", "S01E04", "M. Night Shaym-Aliens!", "https://rickandmortyapi.com/api/episode/4" },
                    { 5, "January 20, 2014", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.236Z", "S01E05", "Meeseeks and Destroy", "https://rickandmortyapi.com/api/episode/5" },
                    { 6, "January 27, 2014", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.339Z", "S01E06", "Rick Potion #9", "https://rickandmortyapi.com/api/episode/6" },
                    { 7, "March 10, 2014", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.441Z", "S01E07", "Raising Gazorpazorp", "https://rickandmortyapi.com/api/episode/7" },
                    { 8, "March 17, 2014", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.543Z", "S01E08", "Rixty Minutes", "https://rickandmortyapi.com/api/episode/8" },
                    { 9, "March 24, 2014", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.645Z", "S01E09", "Something Ricked This Way Comes", "https://rickandmortyapi.com/api/episode/9" },
                    { 10, "April 7, 2014", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.747Z", "S01E10", "Close Rick-counters of the Rick Kind", "https://rickandmortyapi.com/api/episode/10" },
                    { 11, "April 14, 2014", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.850Z", "S01E11", "Ricksy Business", "https://rickandmortyapi.com/api/episode/11" },
                    { 12, "July 26, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:34.953Z", "S02E01", "A Rickle in Time", "https://rickandmortyapi.com/api/episode/12" },
                    { 13, "August 2, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:35.055Z", "S02E02", "Mortynight Run", "https://rickandmortyapi.com/api/episode/13" },
                    { 14, "August 9, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:35.158Z", "S02E03", "Auto Erotic Assimilation", "https://rickandmortyapi.com/api/episode/14" },
                    { 15, "August 16, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:35.261Z", "S02E04", "Total Rickall", "https://rickandmortyapi.com/api/episode/15" },
                    { 16, "August 23, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:35.364Z", "S02E05", "Get Schwifty", "https://rickandmortyapi.com/api/episode/16" },
                    { 17, "August 30, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:35.467Z", "S02E06", "The Ricks Must Be Crazy", "https://rickandmortyapi.com/api/episode/17" },
                    { 18, "September 13, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:35.569Z", "S02E07", "Big Trouble in Little Sanchez", "https://rickandmortyapi.com/api/episode/18" },
                    { 19, "September 20, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:35.669Z", "S02E08", "nterdimensional Cable 2: Tempting Fate", "https://rickandmortyapi.com/api/episode/19" },
                    { 20, "September 27, 2015", "https://rickandmortyapi.com/api/character/1", "2017-11-10T12:56:35.772Z", "S02E09", "Look Who's Purging Now", "https://rickandmortyapi.com/api/episode/20" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RickResults");
        }
    }
}
