namespace Task.Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public required string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
        public required DateTime BirthDate { get; set; }
        public required string MobileNumber { get; set; }
        public required string Email { get; set; }
        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

        public override string ToString()
        {
            return $"{UserID} - {FirstName} {MiddleName} {LastName}, {BirthDate}, {MobileNumber}, {Email}";
        }
    }
}
