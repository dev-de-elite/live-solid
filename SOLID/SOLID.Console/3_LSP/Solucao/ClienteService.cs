namespace SOLID.Console._3_LSP.Solucao;

public class ClienteService
{
    public void Executar(Pessoa cliente)
    {
        if (!cliente.Validar())
            return;
        // Executa o processo
    }
}
