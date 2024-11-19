namespace RegistrationFormApi.Application.Features.Cities.DTOs
{
    public class CityDto
    {
        public int CityID { get; set; }
        public required string CityName { get; set; }
        public required int GovernateID { get; set; }
    }
}
