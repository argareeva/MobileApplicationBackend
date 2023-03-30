using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("tournaments")]
public class Tournament
{
    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("description")]
    public string Description { get; init; }

    [Column("place")]
    public string Place { get; init; }

    [Column("name")]
    public string Name { get; init; }

    [Column("date")]
    public DateTime Date { get; init; }

    public Tournament(int id, DateTime date, string name, string place, string description)
    {
        Id = id;
        Date = date;
        Name = name;
        Place = place;
        Description = description;
    }
}