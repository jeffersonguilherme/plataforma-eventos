using Application.EventoCQ.Commands;
using Application.EventoCQ.ViewModels;
using Domain.Entity;
using Infra.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.EventoCQ.Handlers;

public class UpdateEventoCommandHandle(EventoDbContext context) : IRequestHandler<UpdateEventoCommand, EventoInfoViewModel>
{
    public async Task<EventoInfoViewModel> Handle(UpdateEventoCommand request, CancellationToken cancellationToken)
    {
        var evento = await context.Eventos.FirstOrDefaultAsync(x => x.Id == request.Id);
        if (evento is null)
            throw new Exception("Evento não encontrado");

        evento.Titulo = request.Titulo;
        evento.Descricao = request.Descricao;
        evento.Local = request.Local;
        evento.Tipo = request.Tipo;
        evento.DataFinalIncricao = request.DataFinalIncricao;

        context.Eventos.Update(evento);
        await context.SaveChangesAsync();

        return new EventoInfoViewModel
        {
            Id = evento.Id,
            Titulo = evento.Titulo,
            Descricao = evento.Descricao,
            Local = evento.Local,
            Tipo = (Domain.Enum.TipoEnum)evento.Tipo,
            DataFinalIncricao = evento.DataFinalIncricao
        };
    }
}
