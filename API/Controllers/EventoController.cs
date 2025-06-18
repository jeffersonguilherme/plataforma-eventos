using Application.EventoCQ.Commands;
using Application.EventoCQ.Queries;
using Application.EventoCQ.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventoController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpPost("create-evento")]
    public async Task<ActionResult<EventoInfoViewModel>> CreateEvento(CreateEventoCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpGet("all-eventos")]
    public async Task<ActionResult<List<EventoInfoViewModel>>> GetAllEventos()
    {
        return Ok(await _mediator.Send(new GetAllEventosQuery()));
    }
}