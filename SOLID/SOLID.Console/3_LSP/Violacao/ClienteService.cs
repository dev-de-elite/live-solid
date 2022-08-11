namespace SOLID.Console._3_LSP.Violacao;

public class ClienteService
{
    public void Executar(Cliente cliente)
    {
        if (!cliente.Validar())
            return;
        // Executa o processo
    }
}
