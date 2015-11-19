using System.Collections.Generic;
using System.Security.Policy;

namespace Models.Interfaces
{
    public interface ISubject : IModel
    {
        int Id { get; set; }
        string Name { get; set; }
        List<string> Topics { get; set; }
    }
}