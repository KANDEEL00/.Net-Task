using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RegistrationFormApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedGovernatesAndCities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Governates",
                columns: new[] { "GovernateID", "GovernateName" },
                values: new object[,]
                {
                    { 1, "Cairo" },
                    { 2, "Alexandria" },
                    { 3, "Giza" },
                    { 4, "Qalyubia" },
                    { 5, "Dakahlia" },
                    { 6, "Sharqia" },
                    { 7, "Kafr El Sheikh" },
                    { 8, "Beheira" },
                    { 9, "Minufiya" },
                    { 10, "Gharbia" },
                    { 11, "Beni Suef" },
                    { 12, "Faiyum" },
                    { 13, "Menya" },
                    { 14, "Asyut" },
                    { 15, "Sohag" },
                    { 16, "Qena" },
                    { 17, "Luxor" },
                    { 18, "Aswan" },
                    { 19, "Red Sea" },
                    { 20, "North Sinai" },
                    { 21, "South Sinai" },
                    { 22, "Matruh" },
                    { 23, "New Valley" },
                    { 24, "Port Said" },
                    { 25, "Suez" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "GovernateID" },
                values: new object[,]
                {
                    { 1, "Abbasiya", 1 },
                    { 2, "New Cairo", 1 },
                    { 3, "Heliopolis", 1 },
                    { 4, "Nasr City", 1 },
                    { 5, "Alexandria", 2 },
                    { 6, "Sidi Bishr", 2 },
                    { 7, "El Montaza", 2 },
                    { 8, "6th of October", 3 },
                    { 9, "Badrashin", 3 },
                    { 10, "Kerdasa", 3 },
                    { 11, "Benha", 4 },
                    { 12, "Shibin El Kom", 4 },
                    { 13, "Mansoura", 5 },
                    { 14, "Talkha", 5 },
                    { 15, "Dikirnis", 5 },
                    { 16, "Zagazig", 6 },
                    { 17, "Mashtool El Souq", 6 },
                    { 18, "Kafr El Sheikh", 7 },
                    { 19, "Desouk", 7 },
                    { 20, "Damanhur", 8 },
                    { 21, "Kafr El Dawar", 8 },
                    { 22, "Shibin El Kom", 9 },
                    { 23, "Minuf", 9 },
                    { 24, "Tanta", 10 },
                    { 25, "El Mahalla El Kubra", 10 },
                    { 26, "Beni Suef", 11 },
                    { 27, "Ehnasia", 11 },
                    { 28, "Faiyum", 12 },
                    { 29, "Ibshaway", 12 },
                    { 30, "Minya", 13 },
                    { 31, "Abu Qurqas", 13 },
                    { 32, "Asyut", 14 },
                    { 33, "Sahel Selim", 14 },
                    { 34, "Sohag", 15 },
                    { 35, "Gerga", 15 },
                    { 36, "Qena", 16 },
                    { 37, "Nag Hammadi", 16 },
                    { 38, "Luxor", 17 },
                    { 39, "Esna", 17 },
                    { 40, "Aswan", 18 },
                    { 41, "Kom Ombo", 18 },
                    { 42, "Hurghada", 19 },
                    { 43, "Safaga", 19 },
                    { 44, "El Arish", 20 },
                    { 45, "Sheikh Zuweid", 20 },
                    { 46, "Sharm El Sheikh", 21 },
                    { 47, "Dahab", 21 },
                    { 48, "Matruh", 22 },
                    { 49, "Sidi Abdel Rahman", 22 },
                    { 50, "Kharga", 23 },
                    { 51, "Dakhla", 23 },
                    { 52, "Port Said", 24 },
                    { 53, "Suez", 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Governates",
                keyColumn: "GovernateID",
                keyValue: 25);
        }
    }
}
