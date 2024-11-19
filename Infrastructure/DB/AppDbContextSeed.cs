using Microsoft.EntityFrameworkCore;
using RegistrationFormApi.Domain.Entities;

namespace RegistrationFormApi.Infrastructure.DB
{
    public static class AppDbContextSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Governate>().HasData(
                new Governate { GovernateID = 1, GovernateName = "Cairo" },
                new Governate { GovernateID = 2, GovernateName = "Alexandria" },
                new Governate { GovernateID = 3, GovernateName = "Giza" },
                new Governate { GovernateID = 4, GovernateName = "Qalyubia" },
                new Governate { GovernateID = 5, GovernateName = "Dakahlia" },
                new Governate { GovernateID = 6, GovernateName = "Sharqia" },
                new Governate { GovernateID = 7, GovernateName = "Kafr El Sheikh" },
                new Governate { GovernateID = 8, GovernateName = "Beheira" },
                new Governate { GovernateID = 9, GovernateName = "Minufiya" },
                new Governate { GovernateID = 10, GovernateName = "Gharbia" },
                new Governate { GovernateID = 11, GovernateName = "Beni Suef" },
                new Governate { GovernateID = 12, GovernateName = "Faiyum" },
                new Governate { GovernateID = 13, GovernateName = "Menya" },
                new Governate { GovernateID = 14, GovernateName = "Asyut" },
                new Governate { GovernateID = 15, GovernateName = "Sohag" },
                new Governate { GovernateID = 16, GovernateName = "Qena" },
                new Governate { GovernateID = 17, GovernateName = "Luxor" },
                new Governate { GovernateID = 18, GovernateName = "Aswan" },
                new Governate { GovernateID = 19, GovernateName = "Red Sea" },
                new Governate { GovernateID = 20, GovernateName = "North Sinai" },
                new Governate { GovernateID = 21, GovernateName = "South Sinai" },
                new Governate { GovernateID = 22, GovernateName = "Matruh" },
                new Governate { GovernateID = 23, GovernateName = "New Valley" },
                new Governate { GovernateID = 24, GovernateName = "Port Said" },
                new Governate { GovernateID = 25, GovernateName = "Suez" }
            );

            modelBuilder.Entity<City>().HasData(
                new City { CityID = 1, CityName = "Abbasiya", GovernateID = 1 },
                new City { CityID = 2, CityName = "New Cairo", GovernateID = 1 },
                new City { CityID = 3, CityName = "Heliopolis", GovernateID = 1 },
                new City { CityID = 4, CityName = "Nasr City", GovernateID = 1 },
                new City { CityID = 5, CityName = "Alexandria", GovernateID = 2 },
                new City { CityID = 6, CityName = "Sidi Bishr", GovernateID = 2 },
                new City { CityID = 7, CityName = "El Montaza", GovernateID = 2 },
                new City { CityID = 8, CityName = "6th of October", GovernateID = 3 },
                new City { CityID = 9, CityName = "Badrashin", GovernateID = 3 },
                new City { CityID = 10, CityName = "Kerdasa", GovernateID = 3 },
                new City { CityID = 11, CityName = "Benha", GovernateID = 4 },
                new City { CityID = 12, CityName = "Shibin El Kom", GovernateID = 4 },
                new City { CityID = 13, CityName = "Mansoura", GovernateID = 5 },
                new City { CityID = 14, CityName = "Talkha", GovernateID = 5 },
                new City { CityID = 15, CityName = "Dikirnis", GovernateID = 5 },
                new City { CityID = 16, CityName = "Zagazig", GovernateID = 6 },
                new City { CityID = 17, CityName = "Mashtool El Souq", GovernateID = 6 },
                new City { CityID = 18, CityName = "Kafr El Sheikh", GovernateID = 7 },
                new City { CityID = 19, CityName = "Desouk", GovernateID = 7 },
                new City { CityID = 20, CityName = "Damanhur", GovernateID = 8 },
                new City { CityID = 21, CityName = "Kafr El Dawar", GovernateID = 8 },
                new City { CityID = 22, CityName = "Shibin El Kom", GovernateID = 9 },
                new City { CityID = 23, CityName = "Minuf", GovernateID = 9 },
                new City { CityID = 24, CityName = "Tanta", GovernateID = 10 },
                new City { CityID = 25, CityName = "El Mahalla El Kubra", GovernateID = 10 },
                new City { CityID = 26, CityName = "Beni Suef", GovernateID = 11 },
                new City { CityID = 27, CityName = "Ehnasia", GovernateID = 11 },
                new City { CityID = 28, CityName = "Faiyum", GovernateID = 12 },
                new City { CityID = 29, CityName = "Ibshaway", GovernateID = 12 },
                new City { CityID = 30, CityName = "Minya", GovernateID = 13 },
                new City { CityID = 31, CityName = "Abu Qurqas", GovernateID = 13 },
                new City { CityID = 32, CityName = "Asyut", GovernateID = 14 },
                new City { CityID = 33, CityName = "Sahel Selim", GovernateID = 14 },
                new City { CityID = 34, CityName = "Sohag", GovernateID = 15 },
                new City { CityID = 35, CityName = "Gerga", GovernateID = 15 },
                new City { CityID = 36, CityName = "Qena", GovernateID = 16 },
                new City { CityID = 37, CityName = "Nag Hammadi", GovernateID = 16 },
                new City { CityID = 38, CityName = "Luxor", GovernateID = 17 },
                new City { CityID = 39, CityName = "Esna", GovernateID = 17 },
                new City { CityID = 40, CityName = "Aswan", GovernateID = 18 },
                new City { CityID = 41, CityName = "Kom Ombo", GovernateID = 18 },
                new City { CityID = 42, CityName = "Hurghada", GovernateID = 19 },
                new City { CityID = 43, CityName = "Safaga", GovernateID = 19 },
                new City { CityID = 44, CityName = "El Arish", GovernateID = 20 },
                new City { CityID = 45, CityName = "Sheikh Zuweid", GovernateID = 20 },
                new City { CityID = 46, CityName = "Sharm El Sheikh", GovernateID = 21 },
                new City { CityID = 47, CityName = "Dahab", GovernateID = 21 },
                new City { CityID = 48, CityName = "Matruh", GovernateID = 22 },
                new City { CityID = 49, CityName = "Sidi Abdel Rahman", GovernateID = 22 },
                new City { CityID = 50, CityName = "Kharga", GovernateID = 23 },
                new City { CityID = 51, CityName = "Dakhla", GovernateID = 23 },
                new City { CityID = 52, CityName = "Port Said", GovernateID = 24 },
                new City { CityID = 53, CityName = "Suez", GovernateID = 25 }
            );
        }
    }
}
