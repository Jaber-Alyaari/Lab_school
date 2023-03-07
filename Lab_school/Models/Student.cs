using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lab_school.Models
{
    [Table("student")]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Fname { get; set; } = null!;
        [StringLength(255)]
        public string Lname { get; set; } = null!;
        [StringLength(25)]
        public string Gender { get; set; } = null!;
        [Column(TypeName = "date")]
        public DateTime? Bdate { get; set; }
        [Column("Blood_Group")]
        [StringLength(5)]
        public string? BloodGroup { get; set; }
        [StringLength(255)]
        public string? Religion { get; set; }
        [Column("E_Mail")]
        [StringLength(255)]
        public string? EMail { get; set; }
        public int? Class { get; set; }
        [StringLength(20)]
        public string? Section { get; set; }
        [Column("Admission_ID")]
        public int? AdmissionId { get; set; }
        public int? Phone { get; set; }
    }
}
