namespace Auto_Mapper.Entities
{
    public class Address
    {
        public int Id { get; set; } = 1;

        public string? Street { get; set; } = "AutoStrad";

        public string? City { get; set; } = "Cairo";

        public string? Region { get; set; } = "East Cairo";

        public int? PostalCode { get; set; } = 12345;

        public string? Country { get; set; } = "Egypt";
    }
}
