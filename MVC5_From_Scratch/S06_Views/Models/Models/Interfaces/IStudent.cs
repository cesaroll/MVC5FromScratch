namespace Models.Interfaces
{
    public interface IStudent : IModel
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        bool IsActive { get; set; }
    }
}