using System.ComponentModel.DataAnnotations;

namespace api.Models;

public class Book
{
    [Key]
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public string Review { get; set; }
    public bool IsRead { get; set; }
}