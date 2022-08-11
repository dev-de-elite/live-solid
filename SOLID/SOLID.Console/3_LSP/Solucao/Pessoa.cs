namespace SOLID.Console._3_LSP.Solucao;

public class Pessoa
{
    public virtual string Cpf { get; set; } = default!;

    public bool Validar()
    {
        if (Cpf.Length != 11)
            return false;

        return true;
    }
}
