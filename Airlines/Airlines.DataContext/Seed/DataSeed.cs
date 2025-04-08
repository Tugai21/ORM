using Airlines.Models;
using DataContext;
using Microsoft.EntityFrameworkCore;

namespace Airlines.Seed
{
    public class DataSeed
    {
        #region Continents
        private static List<Continent> continentList = new List<Continent>
        {
            new Continent()
            {
                Id = 1,
                ContinentName="Europe",
                CreatedAt = DateTimeOffset.UtcNow,
            },
            new Continent()
            {
                Id = 2,
                ContinentName="Asia",
                CreatedAt = DateTimeOffset.UtcNow,
            },
        };
        private static List<Country> countryList = new List<Country>
        {
            new Country()
            {
                Id = 1,
                CountryName="Bulgaria",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = continentList[0].Id
            },
            new Country()
            {
                Id=2,
                 CountryName="Romania",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = continentList[0].Id
            },
            new Country()
            {
                  Id = 3,
                 CountryName="France",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = continentList[0].Id
            },
            new Country()
            {
                  Id = 4,
                 CountryName="Italy",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = continentList[0].Id
            },
            new Country()
            {
                  Id = 5,
                 CountryName="Spain",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = continentList[0].Id
            },
            new Country()
            {
                  Id = 6,
                 CountryName="Japan",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = continentList[1].Id
            },
            new Country()
            {
                  Id = 7,
                 CountryName="China",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = continentList[1].Id
            },
            new Country()
            {
                    Id = 8,
                 CountryName="Malaysia",
                CreatedAt = DateTimeOffset.UtcNow,
                ContinentId = continentList[1].Id
            }
        };
        private static List<City> cityList = new List<City>()
        {
            new City()
            {   
                Id = 1,
                CityName="Sofia",
                CountryId = countryList[0].Id,
                CreatedAt = DateTimeOffset.UtcNow
            },
            new City()
            {
                Id = 2,
                CityName="Plovdiv",
                CountryId = countryList[0].Id,
                CreatedAt = DateTimeOffset.UtcNow
            },
            new City()
            {
                Id = 3,
                CityName = "Bucharest",
                CountryId = countryList[1].Id,
                CreatedAt = DateTimeOffset.UtcNow
            },
            new City()
            {
                Id = 4,
                CityName = "Paris",
                CountryId = countryList[2].Id,
                CreatedAt = DateTimeOffset.UtcNow
            }
        };
        private static List<Airport> airportList = new List<Airport>()
        {
            new Airport()
            {
                Id = 1,
                Name = "Sofia International Airport EAD",
                CityId = cityList[0].Id,
                CreatedAt = DateTimeOffset.UtcNow
            },
            new Airport()
            {
                Id = 2,
                Name = "Plovdiv Airport",
                CityId = cityList[0].Id,
                CreatedAt = DateTimeOffset.UtcNow
            },
            new Airport()
            {
                Id = 3,
                Name = "Henri Coanda International Airport",
                CityId = cityList[2].Id,
                CreatedAt = DateTimeOffset.UtcNow
            },
            new Airport()
            {
                Id = 4,
                Name = "Charles de Gaulle Airport",
                CityId = cityList[3].Id,
                CreatedAt = DateTimeOffset.UtcNow
            }


        };
        #endregion
        public static void ExampleSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>().HasData(continentList);
            modelBuilder.Entity<Country>().HasData(countryList);
            modelBuilder.Entity<City>().HasData(cityList);
            modelBuilder.Entity<Airport>().HasData(airportList);
        }
        public void AddContinentsAndCountries()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Country country = db.Countries.FirstOrDefault(x=>x.Id==1);
                country.CountryName = "Bulgaria";
                db.Countries.Update(country);
                db.SaveChanges();
            }
        }
    }
}
