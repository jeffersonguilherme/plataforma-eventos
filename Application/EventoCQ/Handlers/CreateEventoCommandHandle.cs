using Application.EventoCQ.Commands;
using Application.EventoCQ.ViewModels;
using Domain.Entity;
using Infra.Persistence;
using MediatR;

namespace Application.EventoCQ.Handlers;

public class CreateEventoCommandHandle(EventoDbContext context) : IRequestHandler<CreateEventoCommand, EventoInfoViewModel>
{
    private readonly EventoDbContext _eventoDbContext = context;
    public async Task<EventoInfoViewModel> Handle(CreateEventoCommand request, CancellationToken cancellationToken)
    {
        var evento = new Evento()
        {
            Titulo = request.Titulo,
            Descricao = request.Descricao,
            Local = request.Local,
            Tipo =request.Tipo,
            DataFinalIncricao = request.DataFinalIncricao
        };
        _eventoDbContext.Eventos.Add(evento);
        await _eventoDbContext.SaveChangesAsync();
        
        return new EventoInfoViewModel
        {
            Titulo = evento.Titulo,
            Descricao = evento.Descricao,
            Local = evento.Local,
            DataFinalIncricao = evento.DataFinalIncricao,
        };
    }
}
