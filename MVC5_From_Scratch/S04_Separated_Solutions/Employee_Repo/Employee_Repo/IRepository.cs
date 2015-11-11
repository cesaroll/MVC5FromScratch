namespace Employee_Repo
{
    public interface IRepository<T>
    {
        T Get(int id);
    }
}