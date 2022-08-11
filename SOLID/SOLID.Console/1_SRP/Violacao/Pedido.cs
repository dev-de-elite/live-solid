namespace SOLID.Console._1_SRP.Violacao;

public class Pedido
{
    public int Id { get; set; }
    public DateTime DataRealizado { get; set; }
    public Cliente Cliente { get; set; } = default!;
}

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = default!;
    public string Cpf { get; set; } = default!;
    public string Email { get; set; } = default!;
}
