using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("tournament_student")]
public class Tournament_student_link
{
    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("tournament_id")]
    public int Id_tournament { get; set; }
    
    [Column("student_id")]
    public int Id_student { get; set; }
}