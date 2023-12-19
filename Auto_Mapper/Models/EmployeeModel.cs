using Auto_Mapper.Entities;

namespace Auto_Mapper.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; } = 2;

        public string? Name { get; set; }

        public int Age { get; set; }

        public AddressModel? Address { get; set; } 
    }
}
