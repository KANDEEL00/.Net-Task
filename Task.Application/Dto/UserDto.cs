namespace RegistrationFormApi.Application.Dto
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public List<AddressDto> Addresses { get; set; } = new List<AddressDto>();
    }

}
