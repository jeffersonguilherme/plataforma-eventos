using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Inscricao
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public Guid? EventoId { get; set; }
    public Evento? Evento { get; set; }
    
    [Required]
    public Guid? ParticipanteId { get; set; }
    public Participante? Participante { get; set; }
    public DateTime? DataInscricao { get; set; } = DateTime.Now;
}