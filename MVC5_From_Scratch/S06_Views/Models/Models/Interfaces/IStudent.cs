using System;
using Models.Models;

namespace Models.Interfaces
{
    public interface IStudent : IModel
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        bool IsActive { get; set; }
        DateTime JoinDate { get; set; }
        Course Course { get; set; }
    }
}