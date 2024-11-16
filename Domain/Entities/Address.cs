namespace RegistrationFormApi.Domain.Entities
{
    public class Address
    {
        public int AddressID { get; set; }
        public required string Street { get; set; }
        public required string BuildingNumber { get; set; }
        public required int FlatNumber { get; set; }
        public required int UserID { get; set; }

        public virtual User User { get; set; } = null!;
        public required int GovernateID { get; set; }
        public virtual Governate Governate { get; set; } = null!;
        public required int CityID { get; set; }
        public virtual City City { get; set; } = null!;
    }
}
