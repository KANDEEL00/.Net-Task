﻿namespace Task.Application.Dto
{
    public class AddressDto
    {
        public int GovernateID { get; set; }
        public int CityID { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int FlatNumber { get; set; }
    }

}