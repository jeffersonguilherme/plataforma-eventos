using Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity;

[Table("Evento")]
public class Evento
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(45, MinimumLength = 2)]
    public string? Titulo { get; set; }

    [Required]
    [StringLength(120, MinimumLength = 2)]
    public string? Descricao { get; set; }

    [Required]
    public string? Local { get; set; }
    public TipoEnum? Tipo { get; set; } = TipoEnum.Palestra;
    public DateTime? DataCriacao { get; set; } = DateTime.Now;
    public DateTime? DataInicialIncricao { get; set; } = DateTime.Now;

    [Required]
    public DateTime? DataFinalIncricao { get; set; }
    public ICollection<Inscricao>? Inscricoes { get; set; }
}