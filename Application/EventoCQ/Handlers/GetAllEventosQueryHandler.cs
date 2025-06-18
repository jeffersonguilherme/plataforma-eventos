using Application.EventoCQ.Queries;
using Application.EventoCQ.ViewModels;
using Infra.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application.EventoCQ.Handlers;

public class GetAllEventosQueryHandler : IRequestHandler<GetAllEventosQuery, List<EventoInfoViewModel>>
{
    private readonly EventoDbContext _context;

    public GetAllEventosQueryHandler(EventoDbContext context)
    {
        _context = context;
    }
    public async Task<List<EventoInfoViewModel>> Handle(GetAllEventosQuery request, CancellationToken cancellationToken)
    {
        var eventos = await _context.Eventos
            .AsNoTracking()
            .Select(evento => new EventoInfoViewModel
            {
                Titulo = evento.Titulo,
                Descricao = evento.Descricao,
                Local = evento.Local,
                Tipo = Domain.Enum.TipoEnum.Palestra,
                DataCriacao = evento.DataCriacao,
                DataInicialIncricao = evento.DataInicialIncricao,
                DataFinalIncricao = evento.DataFinalIncricao

            })
            .ToListAsync(cancellationToken);

        return eventos;
    }
}
