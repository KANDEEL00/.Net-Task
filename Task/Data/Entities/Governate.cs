namespace Task.Data.Entities
{
    public class Governate
    {
        public int GovernateID { get; set; }
        public required string GovernateName { get; set; }
        public virtual ICollection<City> Cities { get; set; } = new List<City>();
        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
        public virtual GovernateUserCount GovernateUserCount { get; set; } = null!;
    }
}