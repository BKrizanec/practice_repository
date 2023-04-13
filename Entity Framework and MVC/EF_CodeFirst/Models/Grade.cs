using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_CodeFirst.Models;

public class Grade
{
    [Key]
    public int GradeId { get; set; }

    [Required, Column(TypeName = "nvarchar")]
    [StringLength(200)]
    public string GradeName { get; set; }

    [Required, Column(TypeName = "nvarchar")]    
    [StringLength(200)]
    public string Section { get; set; }

    public int StudentId { get; set; }
    [ForeignKey(nameof(StudentId))]
    public Student Student { get; set; }
    
}
