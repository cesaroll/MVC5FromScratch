using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Models.Interfaces;

namespace Models.Models
{
    public class Subject: Model, ISubject
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Topics { get; set; }
    }
}