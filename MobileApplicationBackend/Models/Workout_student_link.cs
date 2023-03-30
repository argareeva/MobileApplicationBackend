using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("workout_student")]
public class Workout_student_link
{
    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("workout_id")]
    public int Id_seminar { get; set; }
    
    [Column("student_id")]
    public int Id_student { get; set; }
}