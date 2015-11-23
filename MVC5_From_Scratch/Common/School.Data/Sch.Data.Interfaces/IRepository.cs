using System.Collections.Generic;
using Ces.Sch.Models.Interfaces;

namespace Ces.Sch.Data.Interfaces
{
    public interface IRepository<T> where T : IModel
    {
        T Get(int id);

        IEnumerable<T> GetAll();
    }
}