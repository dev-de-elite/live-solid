using System.Text.RegularExpressions;

namespace SOLID.Console._3_LSP.Violacao;

public class Cliente : Pessoa
{
    public override string Cpf
    {
        get => base.Cpf;
        // Aplicando REGEX de máscara de CPF: 000.000.000-00
        set => base.Cpf = new Regex(@"/(\d{3})(\d{3})(\d{3})(\d{2})/g").Replace(value, "$1.$2.$3-$4");
    }
}
