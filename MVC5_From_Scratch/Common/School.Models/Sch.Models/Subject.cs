using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ces.Sch.Models.Interfaces;

namespace Ces.Sch.Models
{
    public class Subject : Model, ISubject
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Topics { get; set; }
    }
}