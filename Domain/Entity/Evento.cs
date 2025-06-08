using Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;


public class Evento
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(45, MinimunLenth = 2)]
    public string? Titulo { get; set; }
    
    public string? Descricao { get; set; }
    public string? Local { get; set; }
    public TipoEnum? Tipo { get; set; } = TipoEnum.Palestra;
    public DateTime? DataCriacao { get; set; } = DateTime.Now;
    public DateTime? DataInicialIncricao { get; set; } = DateTime.Now;
    public DateTime? DataFinalIncricao { get; set; }
    public ICollection<Inscricao>? Inscricoes { get; set; }
}