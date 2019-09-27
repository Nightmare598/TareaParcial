using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evaluation.Models
{
    public enum TypeStatus { Approved, Reproved }
    public enum TypeSubject { Math, History, Geography, English, Spanish, Science }
    public class Grade
    {
        [Key]
        public TypeSubject Subject { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage ="Please enter the correct value")]
        public int Prom { get; set; }
        [Required]
        public TypeStatus Status { get; set; }

    }
}