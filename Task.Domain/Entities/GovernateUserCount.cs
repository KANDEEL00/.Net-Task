namespace Task.Domain.Entities
{
    public class GovernateUserCount
    {
        public int GovernateID { get; set; }
        public int UserCount { get; set; } = 0;
        public virtual Governate Governate { get; set; } = null!;
    }
}