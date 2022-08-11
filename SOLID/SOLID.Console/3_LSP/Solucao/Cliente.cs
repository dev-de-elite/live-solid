using System.Text.RegularExpressions;

namespace SOLID.Console._3_LSP.Solucao;

public class Cliente : Pessoa
{
    private string _cpfFormatado = default!;
    public string CpfFormatado =>
        string.IsNullOrWhiteSpace(_cpfFormatado) ?
        _cpfFormatado = new Regex(@"/(\d{3})(\d{3})(\d{3})(\d{2})/g").Replace(Cpf, "$1.$2.$3-$4") :
        _cpfFormatado;
}
