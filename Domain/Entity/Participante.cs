using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entity;

[Table("Participantes")]
public class Participante
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(45, MinimumLength = 2)]
    public string? Name { get; set; }

    [Required]
    [StringLength(45, MinimumLength = 2)]
    public string? Sobrenome { get; set; }

    [Required]
    public string? Telefone { get; set; }

    [Required]
    public string? Email { get; set; }

    [Required]
    public DateTime? DataNascimento { get; set; }

    [Required]
    public string? UserName { get; set; }

    [Required]
    [StringLength(45, MinimumLength = 8)]
    public string? PasswordHash { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpirationTime { get; set; }
    public ICollection<Inscricao>? Inscricoes { get; set; }
}