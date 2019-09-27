using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evaluation.Models
{
    public enum TypeStatus { Approved, Reproved }
    public class Grade
    {
        [Key]
        public string Subject { get; set; }
        [Required]
        public int Prom { get; set; }
        [Required]
        public TypeStatus Status { get; set; }

    }
}