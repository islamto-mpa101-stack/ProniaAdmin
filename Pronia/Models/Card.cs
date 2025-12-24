using System.ComponentModel.DataAnnotations;

namespace Pronia.Models;

public class Card
{   
    public int Id { get; set; }
    [MinLength(5,ErrorMessage ="Min length: 5")]
    public string Title { get; set; } = null!;
    [Required(ErrorMessage ="Field can't be empty!")]
    public string Description { get; set; } = null!;
    public string ImagePath { get; set; } = null!;


}
