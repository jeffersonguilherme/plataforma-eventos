namespace Domain.Entity;

public class Inscricao
{
    public Guid Id { get; set; }
    public Guid? EventoId { get; set; }
    public Evento? Evento { get; set; }
    public Guid? ParticipanteId { get; set; }
    public Participante? Participante { get; set; }
    public DateTime? DataInscricao { get; set; } = DateTime.Now;
}