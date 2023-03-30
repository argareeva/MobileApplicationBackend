using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileApplicationBackend.Models;
[Table("news")]
public class News
{
    [Key]
    [Column("id")]
    public int Id { get; init; }
    
    [Column("date")]
    public DateTime Date { get; init; }
    
    [Column("header")]
    public string Header { get; init; }
    
    [Column("content")]
    public string Content { get; init; }

    public News(int id, DateTime date, string header, string content)
    {
        Id = id;
        Date = date;
        Header = header;
        Content = content;
    }
}