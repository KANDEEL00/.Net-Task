namespace RegistrationFormApi.Domain.Entities
{
    public class GovernateUserCount
    {
        public int GovernateID { get; set; }
        public virtual Governate Governate { get; set; } = null!;
        public int UserCount { get; set; } = 0;
    }
}