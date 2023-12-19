namespace Auto_Mapper.Entities
{
    public class Employee
    {
        public int Id { get; set; } = 1;

        public string Name { get; set; } = "John Doe";

        public int Age { get; set; } = 32;

        public Address Address { get; set; } = new Address();
    }
}
