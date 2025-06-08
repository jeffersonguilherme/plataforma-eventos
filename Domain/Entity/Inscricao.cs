using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity;

[Table("Inscricao")]
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