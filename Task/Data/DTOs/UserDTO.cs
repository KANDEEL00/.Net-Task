namespace Task.Data.DTOs
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public List<AddressDTO> Addresses { get; set; } = new List<AddressDTO>();
    }
}
