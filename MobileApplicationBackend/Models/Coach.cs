using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("coaches")]
public class Coach
{
    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("email")]
    public string Email { get; init; }
    
    [Column("password")]
    public string Password { get; init; }

    [Column("description")]
    public string Description { get; init; }

    [Column("name")]
    public string FullName { get; init; }

    public Coach(int id, string description, string fullName)
    {
        Id = id;
        Description = description;
        FullName = fullName;
    }
}