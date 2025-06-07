namespace Domain.Entity;

public class Participante
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Sobrenome { get; set; }
    public string? Telefone { get; set; }
    public string? Email { get; set; }
    public DateTime? DataNascimento { get; set; }
    public string? UserName { get; set; }
    public string? PasswordHash { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime? RefreshTokenExpirationTime { get; set; }
    public ICollection<Inscricao>? Inscricoes { get; set; }
}