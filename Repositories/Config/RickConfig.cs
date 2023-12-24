using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class RickConfig : IEntityTypeConfiguration<RickResult>
    {
        public void Configure(EntityTypeBuilder<RickResult> builder)
        {
            builder.HasData(
                new RickResult()
                {
                    Id = 1,
                    Name = "Pilot",
                    AirDate = "December 2, 2013",
                    Episode = "S01E01",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/1",
                    Created = "2017-11-10T12:56:33.798Z",
                },
                new RickResult()
                {
                    Id = 2,
                    Name = "Lawnmower Dog",
                    AirDate = "December 9, 2013",
                    Episode = "S01E02",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/2",
                    Created = "2017-11-10T12:56:33.916Z",
                },
                new RickResult()
                {
                    Id = 3,
                    Name = "Anatomy Park",
                    AirDate = "December 16, 2013",
                    Episode = "S01E03",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/3",
                    Created = "2017-11-10T12:56:34.022Z",
                },
                new RickResult()
                {
                    Id = 4,
                    Name = "M. Night Shaym-Aliens!",
                    AirDate = "January 13, 2014",
                    Episode = "S01E04",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/4",
                    Created = "2017-11-10T12:56:34.129Z",
                },
                new RickResult()
                {
                    Id = 5,
                    Name = "Meeseeks and Destroy",
                    AirDate = "January 20, 2014",
                    Episode = "S01E05",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/5",
                    Created = "2017-11-10T12:56:34.236Z",
                },
                new RickResult()
                {
                    Id = 6,
                    Name = "Rick Potion #9",
                    AirDate = "January 27, 2014",
                    Episode = "S01E06",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/6",
                    Created = "2017-11-10T12:56:34.339Z",
                },
                new RickResult()
                {
                    Id = 7,
                    Name = "Raising Gazorpazorp",
                    AirDate = "March 10, 2014",
                    Episode = "S01E07",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/7",
                    Created = "2017-11-10T12:56:34.441Z",
                },
                new RickResult()
                {
                    Id = 8,
                    Name = "Rixty Minutes",
                    AirDate = "March 17, 2014",
                    Episode = "S01E08",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/8",
                    Created = "2017-11-10T12:56:34.543Z",
                },
                new RickResult()
                {
                    Id = 9,
                    Name = "Something Ricked This Way Comes",
                    AirDate = "March 24, 2014",
                    Episode = "S01E09",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/9",
                    Created = "2017-11-10T12:56:34.645Z",
                },
                new RickResult()
                {
                    Id = 10,
                    Name = "Close Rick-counters of the Rick Kind",
                    AirDate = "April 7, 2014",
                    Episode = "S01E10",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/10",
                    Created = "2017-11-10T12:56:34.747Z",
                },
                new RickResult()
                {
                    Id = 11,
                    Name = "Ricksy Business",
                    AirDate = "April 14, 2014",
                    Episode = "S01E11",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/11",
                    Created = "2017-11-10T12:56:34.850Z",
                },
                new RickResult()
                {
                    Id = 12,
                    Name = "A Rickle in Time",
                    AirDate = "July 26, 2015",
                    Episode = "S02E01",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/12",
                    Created = "2017-11-10T12:56:34.953Z",
                },
                new RickResult()
                {
                    Id = 13,
                    Name = "Mortynight Run",
                    AirDate = "August 2, 2015",
                    Episode = "S02E02",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/13",
                    Created = "2017-11-10T12:56:35.055Z",
                },
                new RickResult()
                {
                    Id = 14,
                    Name = "Auto Erotic Assimilation",
                    AirDate = "August 9, 2015",
                    Episode = "S02E03",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/14",
                    Created = "2017-11-10T12:56:35.158Z",
                },
                new RickResult()
                {
                    Id = 15,
                    Name = "Total Rickall",
                    AirDate = "August 16, 2015",
                    Episode = "S02E04",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/15",
                    Created = "2017-11-10T12:56:35.261Z",
                },
                new RickResult()
                {
                    Id = 16,
                    Name = "Get Schwifty",
                    AirDate = "August 23, 2015",
                    Episode = "S02E05",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/16",
                    Created = "2017-11-10T12:56:35.364Z",
                },
                new RickResult()
                {
                    Id = 17,
                    Name = "The Ricks Must Be Crazy",
                    AirDate = "August 30, 2015",
                    Episode = "S02E06",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/17",
                    Created = "2017-11-10T12:56:35.467Z",
                },
                new RickResult()
                {
                    Id = 18,
                    Name = "Big Trouble in Little Sanchez",
                    AirDate = "September 13, 2015",
                    Episode = "S02E07",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/18",
                    Created = "2017-11-10T12:56:35.569Z",
                },
                new RickResult()
                {
                    Id = 19,
                    Name = "nterdimensional Cable 2: Tempting Fate",
                    AirDate = "September 20, 2015",
                    Episode = "S02E08",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/19",
                    Created = "2017-11-10T12:56:35.669Z",
                },
                new RickResult()
                {
                    Id = 20,
                    Name = "Look Who's Purging Now",
                    AirDate = "September 27, 2015",
                    Episode = "S02E09",
                    Characters = "https://rickandmortyapi.com/api/character/1",
                    Url = "https://rickandmortyapi.com/api/episode/20",
                    Created = "2017-11-10T12:56:35.772Z",
                }
           );
        }
    }
}
