using Domain.Enum;

namespace Application.EventoCQ.ViewModels;

public class EventoInfoViewModel
{
    public Guid Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public string? Local { get; set; }
    public TipoEnum Tipo { get; set; }
    public DateTime? DataCriacao { get; set; }
    public DateTime? DataInicialIncricao { get; set; }
    public DateTime? DataFinalIncricao { get; set; }
}
