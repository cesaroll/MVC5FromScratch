using Models.Interfaces;

namespace Models.Models
{
    public class Student : Model, IStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsActive { get; set; }
    }
}