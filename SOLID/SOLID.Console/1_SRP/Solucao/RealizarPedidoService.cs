namespace SOLID.Console._1_SRP.Solucao;

public class RealizarPedidoService
{
    public async Task<bool> Realizar(Pedido pedido)
    {
        if (!pedido.Validar())
        {
            return default;
        }
        PedidoRepository.Salvar(pedido);
        await EmailService.EnviarEmailPedidoRealizado(pedido.Id, pedido.Cliente.Email.Endereco);
        return true;
    }
}
