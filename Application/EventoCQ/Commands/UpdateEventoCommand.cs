using Application.EventoCQ.ViewModels;
using Domain.Enum;
using MediatR;

namespace Application.EventoCQ.Commands;

public class UpdateEventoCommand : IRequest<EventoInfoViewModel>
{
    public Guid Id { get; set; }
    public string? Titulo { get; set; }
    public string? Descricao { get; set; }
    public string? Local { get; set; }
    public TipoEnum Tipo { get; set; }
    public DateTime? DataFinalIncricao { get; set; }
}