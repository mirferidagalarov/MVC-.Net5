using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MvcProyekt_.Net_5.DAL.DatabaseContext;
using MvcProyekt_.Net_5.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MvcProyekt_.Net_5.DAL.DataSeed
{
    public class DataSeed
    {


        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataContext>();
                if (!context.Positions.Any())

                {
                    context.Positions.AddRangeAsync(new List<Position>() {
            new Position {
              PositionId = 1,
                PositionName = "Chief Information Officer"
                         },
            new Position {
              PositionId = 2,
                PositionName = "Chief Technology Officer"
            },
            new Position {
              PositionId = 3,
                PositionName = "Director of Technology"
            },
            new Position {
              PositionId = 4,
                PositionName = "IT Director"
            },
            new Position {
              PositionId = 5,
                PositionName = "IT Manager"
            },
            new Position {
              PositionId = 6,
                PositionName = "Information Security Analyst"
            },
            new Position {
              PositionId = 7,
                PositionName = "Junior Developer"
            },
            new Position {
              PositionId = 8,
                PositionName = "Senior Software Engineer"
            },
            new Position {
              PositionId = 9,
                PositionName = "Software Architect"
            },
            new Position {
              PositionId = 10,
                PositionName = ".Net Developer"
            }
          });
                    context.SaveChanges();
                }
                if (!context.Months.Any())
                {
                    context.Months.AddRangeAsync(new List<Month>() {
            new Month {
              MonthId = 1,
                MonthName = "Yanvar"
            },
            new Month {
              MonthId = 2,
                MonthName = "Fevral"
            },
            new Month {
              MonthId = 3,
                MonthName = "Mart"
            },
            new Month {
              MonthId = 4,
                MonthName = "Aprel"
            },
            new Month {
              MonthId = 5,
                MonthName = "May"
            },
            new Month {
              MonthId = 6,
                MonthName = "Iyun"
            },
            new Month {
              MonthId = 7,
                MonthName = "Iyul"
            },
            new Month {
              MonthId = 8,
                MonthName = "Avqust"
            },
            new Month {
              MonthId = 9,
                MonthName = "Sentaybr"
            },
            new Month {
              MonthId = 10,
                MonthName = "Oktyabr"
            },
            new Month {
              MonthId = 11,
                MonthName = "Noyabr"
            },
            new Month {
              MonthId = 12,
                MonthName = "Dekabr"
            }
          });
                    context.SaveChanges();
                }
                if (!context.Years.Any())
                {
                    context.Years.AddRangeAsync(new List<Years>()
                    {
                        new Years
                        {
                            YearId = 1,
                            Year = 2020
                        },
                        new Years
                        {
                            YearId = 2,
                            Year = 2021
                        },
                        new Years
                        {
                            YearId = 3,
                            Year = 2022
                        },
                        new Years
                        {
                            YearId = 4,
                            Year = 2023
                        },
                        new Years
                        {
                            YearId = 5,
                            Year = 2024
                        }

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}