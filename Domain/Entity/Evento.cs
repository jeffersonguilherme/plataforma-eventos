namespace Domain.Entity;

public class Evento
{
    public Guid Id { get; set; }
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public string Local { get; set; }
    //public TipoEnum Tipo { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
    public DateTime DataInicialIncricao { get; set; } = DateTime.Now;
    public DateTime DataFinalIncricao { get; set; }
    //public ICollection<Inscricao> Inscricoes { get; set; }
}