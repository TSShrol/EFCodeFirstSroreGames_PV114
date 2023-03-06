using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public static class DatabaseSeedExtension
    {
        public static void SeedStyleGame(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<StyleGame>().HasData(new[] {
                new StyleGame{
                    Id=1,
                    Name="ArcadRaising",
                    Description="Info ArcadRaising..."
                },
                new StyleGame{
                    Id=2,
                    Name="Shooter",
                    Description="Info Shooter..."
                },
                new StyleGame{
                    Id=3,
                    Name="Raising",
                    Description="Info Raising..."
                },
                new StyleGame{
                    Id = 4,
                    Name ="Strategy",
                    Description="Comand game....."
                }

            }
         );
        }

        public static void SeedStudio(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Studio>().HasData(new[] { 
                new Studio{ 
                    Id=1,
                    NameStudio="EAGames Sports",
                    Founder="Noname",
                    Country="USA"
                },
                new Studio{
                    Id=2,
                    NameStudio="Valve",
                    Founder="None",
                    Country="Chine"
                },

                new Studio{
                    Id=3,
                    NameStudio="GSC",
                    Founder="NoName",
                    Country="Ukraine"
                },
            });
        }


        public static void SeedGame(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(new[] {
                new Game{ 
                    Id=1,
                    NameGame = "Need for Speed",
                    StudioId = 1,
                    Release = new DateTime(2015,5,5),
                    CountSell=1000,
                    StyleGameId=1
                },
                new Game{
                    Id=2,
                    NameGame = "Contro Strike",
                    StudioId = 2,
                    Release = new DateTime(2015, 5, 5),
                    CountSell=2000,
                    StyleGameId=2
                },
                new Game{
                    Id=3,
                    NameGame = "My little pony",
                    StudioId = 2,
                    Release = new DateTime(2015, 5, 5),
                    CountSell=1500,
                    StyleGameId=2
                },
                new Game{
                    Id=4,
                    NameGame ="S.T.A.L.K.E.R 2",
                    StudioId=3,
                    Release = new DateTime(2023, 5, 5),
                    CountSell=2500,
                    StyleGameId = 1
                },
                new Game{
                    Id=5,
                    NameGame="Heroes 3.5",
                    StudioId=3,
                    Release = new DateTime(2022, 5, 5),
                    CountSell=3000,
                    StyleGameId = 4
                }
            });
        }
    }
}
