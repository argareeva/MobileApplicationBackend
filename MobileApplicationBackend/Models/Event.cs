using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;

[Table("events")]
public class Event
{
    [Key]
    [Column("id")]
    public int Id { get; init; }

    [Column("header")]
    public string Header { get; init; }

    [Column("date")]
    public DateTime Date { get; init; }

    [Column("place")]
    public string Place { get; init; }

    public Event(int id, string header, DateTime date, string place)
    {
        Id = id;
        Header = header;
        Date = date;
        Place = place;
    }
}