using System.ComponentModel.DataAnnotations;

namespace WebApplication3;

public class Item
{
    [Required]
    public string Name { get; set; }
}