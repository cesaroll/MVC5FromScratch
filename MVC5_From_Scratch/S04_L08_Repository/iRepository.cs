using S04_L08_Models;

namespace S04_L08_Repository
{
    public interface IRepository
    {
        Employee Get(int id);
    }
}