using Application.EventoCQ.ViewModels;
using MediatR;

namespace Application.EventoCQ.Queries;

public record GetAllEventosQuery : IRequest<List<EventoInfoViewModel>>;