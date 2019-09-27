using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evaluation.Models
{
    public enum TypeGender { Male, Female, Helicopter, Other }

    public class Student
    {
        [Key]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        [Required]
        public TypeGender Gender { get; set; }
        public virtual ICollection<Grade> Grade { get; set; }
    }
}