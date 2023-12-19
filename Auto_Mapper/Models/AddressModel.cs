﻿namespace Auto_Mapper.Models
{
    public class AddressModel
    {
        public int Id { get; set; } 

        public string? Street { get; set; }

        public string? City { get; set; }

        public string? Region { get; set; }

        public int? PostalCode { get; set; } 

        public string? Country { get; set; }
    }
}
