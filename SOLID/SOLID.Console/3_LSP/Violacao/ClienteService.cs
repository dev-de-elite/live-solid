namespace SOLID.Console._3_LSP.Violacao;

public class ClienteService
{
    public void Executar(Pessoa pessoa)
    {
        if (!pessoa.Validar())
            return;
        // Executa o processo
    }
}
