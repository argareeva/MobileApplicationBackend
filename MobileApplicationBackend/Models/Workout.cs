using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("workouts")]
public class Workout
{

    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("schedule")]
    public string Schedule { get; init; }
    
    [Column("group")]
    public string Group { get; init; }
    
    [Column("coach_id")]
    public int Coach_id { get; init; }

    public Workout(int id, string schedule, string group)
    {
        Id = id;
        Schedule = schedule;
        Group = group;
    }
}