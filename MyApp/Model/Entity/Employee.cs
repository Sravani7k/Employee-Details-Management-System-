//pojo class
namespace MyApp.Model.Entity
{
    public class Employee
    {
        public Guid Id { get; set; }  //Globally Unique Identifier
        public  required string Name { get; set; } //mandatory
        public required string Email { get; set; }

        public string? Phone { get; set; } //not null

        public decimal Salary { get; set; } //salry decimal type
    }
}
