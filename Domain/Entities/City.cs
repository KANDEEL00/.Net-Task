﻿namespace RegistrationFormApi.Domain.Entities
{
    public class City
    {
        public int CityID { get; set; }
        public required string CityName { get; set; }

        public required int GovernateID { get; set; }
        public virtual Governate Governate { get; set; } = null!;

        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
    }
}