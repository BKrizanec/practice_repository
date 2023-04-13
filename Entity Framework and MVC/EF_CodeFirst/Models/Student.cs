using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models;

public class Student
{
    [Key]
    public int StudentID { get; set; }

    [Required, Column(TypeName = "nchar")]
    [StringLength(200)]
    public string StudentName { get; set; }

    [Required, Column(TypeName = "date")]
    public DateTime DateofBirth { get; set; }

    [Required]
    public decimal Height { get; set; }

    [Required]
    public float Weight { get; set; }
}
