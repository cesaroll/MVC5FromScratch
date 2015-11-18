using System.Collections.Generic;
using Models.Interfaces;

namespace Repo.Interfaces
{
    public interface IRepository<T> where T : IModel
    {
        T Get(int id);

        IEnumerable<T> GetAll();
    }
}