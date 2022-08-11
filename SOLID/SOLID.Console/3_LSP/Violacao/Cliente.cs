using System.Text.RegularExpressions;

namespace SOLID.Console._3_LSP.Violacao;

public class Cliente : Pessoa
{
    public override string Cpf
    {
        get => base.Cpf;
        set => base.Cpf = new Regex(@"/(\d{3})(\d{3})(\d{3})(\d{2})/g").Replace(value, "$1.$2.$3-$4");
    }
}
