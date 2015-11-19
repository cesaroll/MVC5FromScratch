using System;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Models.Interfaces;

namespace Models.Models
{
    public class Student : Model, IStudent
    {
        //[HiddenInput(DisplayValue = false)] //Property Visibility

        [ScaffoldColumn(false)] //Exclude Property
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        //[UIHint("MultilineText")] //Selecting Diplay Template
        [DataType(DataType.MultilineText)] //Other way of selecteing Display template
        public string Address { get; set; }

        [Display(Name="Active")] //Metadata for labels
        public bool IsActive { get; set; }

        [Display(Name="Joining Date")]
        [DataType(DataType.Date)] //Metadata for Data values
        public DateTime JoinDate { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        public Course Course { get; set; } //See Custom Properties in View/Shared/EditorTemplates/Course.cshtml

    }
    
}