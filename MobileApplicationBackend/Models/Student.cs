using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("students")]
public class Student
{
    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("email")]
    public string Email { get; init; }
    
    [Column("password")]
    public string Password { get; init; }

    [Column("name")]
    public string FullName { get; init; }

    [Column("dan")]
    public string? Dan { get; set; }

    [Column("category")]
    public string? Category { get; set; }

    [Column("direction")]
    public string? Direction { get; set; }

    [Column("participation")]
    public bool? Participation { get; set; }
    
    [Column("medals")]
    public string? Medals { get; set; }

    public Student(int id, string fullName)
    {
        Id = id;
        FullName = fullName;
    }
}