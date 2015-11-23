using System.Collections.Generic;

namespace Ces.Sch.Models.Interfaces
{
    public interface ISubject : IModel
    {
        int Id { get; set; }
        string Name { get; set; }
        List<string> Topics { get; set; }
    }
}