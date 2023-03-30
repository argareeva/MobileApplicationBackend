using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("seminar_student")]
public class Seminar_student_link
{
    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("seminar_id")]
    public int Id_seminar { get; set; }
    
    [Column("student_id")]
    public int Id_student { get; set; }
}