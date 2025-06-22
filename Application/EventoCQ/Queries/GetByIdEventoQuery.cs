using Application.EventoCQ.ViewModels;
using MediatR;

namespace Application.EventoCQ.Queries;

public record GetByIdEventoQuery : IRequest<EventoInfoViewModel>;