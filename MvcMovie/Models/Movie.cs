using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [StringLength(60, MinimumLength = 3, ErrorMessage ="Título deve ter no minímo 3 letras e no máximo 60.")]
    [Required (ErrorMessage ="Campo Título é obrigatório.")]
    public string? Title { get; set; }

    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Deve começar um uma letra maiúscula e não são admitidos números nem caracteres especiais.")]
    [Required(ErrorMessage = "Campo Género é obrigatório.")]
    [StringLength(30)]
    public string? Genre { get; set; }

    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Deve começar um uma letra maiúscula e não são admitidos caracteres especiais.")]
    [StringLength(5)]
    [Required(ErrorMessage = "Campo Rating é obrigatório.")]
    public string? Rating { get; set; }
}