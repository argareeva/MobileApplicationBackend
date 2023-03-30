using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("managers")]
public class Manager
{
    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("email")]
    public string Email { get; init; }
    
    [Column("password")]
    public string Password { get; init; }
}