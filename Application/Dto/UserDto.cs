namespace RegistrationFormApi.Application.Dto
{
    public class UserDto
    {
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public required string MobileNumber { get; set; }
        public required string Email { get; set; }
        public List<AddressDto> Addresses { get; set; } = new List<AddressDto>();
    }

}
