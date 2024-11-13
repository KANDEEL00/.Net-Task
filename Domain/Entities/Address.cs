namespace RegistrationFormApi.Domain.Entities
{
    public class Address
    {
        public int AddressID { get; set; }
        public required int UserID { get; set; }
        public required int GovernateID { get; set; }
        public required int CityID { get; set; }
        public required string Street { get; set; }
        public required int BuildingNumber { get; set; }
        public required int FlatNumber { get; set; }
        public virtual User User { get; set; } = null!;
        public virtual Governate Governate { get; set; } = null!;
        public virtual City City { get; set; } = null!;
    }
}
