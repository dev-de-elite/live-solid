namespace SOLID.Console._1_SRP.Solucao;

public class Pedido : IValidar
{
    public int Id { get; set; }
    public DateTime DataRealizado { get; set; }
    public Cliente Cliente { get; set; } = default!;

    public bool Validar() => Cliente.Validar();
}

public class Cliente : IValidar
{
    public int Id { get; set; }
    public string Nome { get; set; } = default!;
    public Cpf Cpf { get; set; } = default!;
    public Email Email { get; set; } = default!;

    public bool Validar() =>
        Cpf.Validar() && Email.Validar();
}

public class Cpf : IValidar
{
    public string Conteudo { get; set; } = default!;

    public bool Validar() => Conteudo.Length != 11;
}

public class Email : IValidar
{
    public string Endereco { get; set; } = default!;

    public bool Validar() => Endereco.Contains('@');
}

public interface IValidar
{
    bool Validar();
}
