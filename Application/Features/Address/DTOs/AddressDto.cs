namespace RegistrationFormApi.Application.Features.Address.DTOs
{
    public class AddressDto
    {
        public int GovernateID { get; set; }
        public int CityID { get; set; }
        public required string Street { get; set; }
        public required string BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
    }

}