using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab_school.Models
{
    [Table("subject")]
    public partial class Subject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Mame { get; set; } = null!;
        [StringLength(255)]
        public string Class { get; set; } = null!;
    }
}
