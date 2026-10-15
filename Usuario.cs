namespace Aulas_C_;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public List<Pedidos> Pedidos { get; set; } = new();
}

public class Pedidos
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public string Produto { get; set; } = string.Empty;
    public decimal Valor { get; set; }

}
